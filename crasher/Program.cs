using crasher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using crasher.Helpers;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Net;
using System.Timers;

namespace crasher
{
    class Program
    {
        public static System.Timers.Timer timerCheck;
        public static Thread guiThread;
        public static Thread attackCheckThread;

        static void Main(string[] args)
        {

            Console.Title = "S.O.I.C | Debug Console";

            Console.WriteLine("--> Welcome. We need some time to startup the application.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Checking account type...");
            Console.ForegroundColor = ConsoleColor.White;

            //
            //FA UNA RICHIESTA E CONTROLLA SE L'ACCOUNT È PREMIUM O MENO TRAMITE IL MAC ADDRESS
            //

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Trying to contact the Orbital Satellite..");
            Console.ForegroundColor = ConsoleColor.White;

            bool status = false;
            while (!status)
            {
                status = StartUpClient();
                if(status == false) {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[Info] Retry in 5 seconds...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(5000);
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[Success] Connected successfully");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


            //Start application via thread
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Loading GUI application...");
            Console.ForegroundColor = ConsoleColor.White;

            guiThread = new Thread(StartGUI);
            guiThread.Start();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Success] GUI loaded correctly");
            Console.ForegroundColor = ConsoleColor.White;

            //CHECK OGNI TOT SECONDI SE L'ACCOUNT È COINVOLTO IN ATTACCHI

            //Timer for attack checking every x seconds
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Contact server for attacks...");
            Console.ForegroundColor = ConsoleColor.White;

            attackCheckThread = new Thread(CheckNewAttacks);
            attackCheckThread.Start(30000);

            //trigger first check
            OnTimedEvent(timerCheck, null);
        }

        /* JOIN MRE & CONNECTS TO TCP SERVER */
        public static bool StartUpClient()
        {
            try
            {
                //PROVA A CONNETTERSI AL MRE
                JArray json = MREHelper.JoinMRE();
                if (MREHelper.JsonGetStatus(json))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You looks new in this place...");

                }
                else
                {
                    //UTENTE SI ERA GIÀ CONNESSO
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Welcome back to the Orbital net, we've missed you.");
                }
                Console.ForegroundColor = ConsoleColor.White;

                return true;
            }
            catch (WebException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;

                return false;
            }
        }

        public static void StartGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }

        public static void CheckNewAttacks(object interval)
        {
            // Create a timer with a two second interval.
            timerCheck = new System.Timers.Timer(Convert.ToInt32(interval));
            // Hook up the Elapsed event for the timer. 
            timerCheck.Elapsed += OnTimedEvent;
            timerCheck.AutoReset = true;
            timerCheck.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ClientHelper.GetUserAttacks();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Next check in {0} second(s)", timerCheck.Interval / 1000);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
