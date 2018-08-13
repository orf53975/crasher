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

namespace crasher
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUpClient();
            StartGUI();
            
            
            /*
            String url;
            int type;
            Console.WriteLine("Crasher tool by Luca Di Bello");
            while (true)
            {
                Console.Write("Victim URL: ");
                url = Console.ReadLine();

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    break;
                }
                else { url = ""; }
            }

            Console.WriteLine();
            */

            /*       
            AttackSettings.Threading = true;
            Attack a = new Attack(url, AttackType.PodAttack);
            a.Start();

            Console.ReadKey();
            */
        }

        /* JOIN MRE */
        public static void StartUpClient()
        {
            JArray json = MREHelper.JoinMRE();
            if (MREHelper.CheckStatus(json))
            {
                Console.WriteLine("Bot added to the server");
            }
            else
            {
                Console.WriteLine(MREHelper.GetMessage(json));
            }
        }

        public static void StartGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
