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
                
                Console.WriteLine(mac);
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
    }
}
