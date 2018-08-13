using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using crasher.Model;

namespace crasher.Helpers
{

    public static class MREHelper
    {
        private static WebClient Client = new WebClient();

        public static JArray JoinMRE()
        {
            //USAGE = adduser.php?name=<name>&os=<os>
            string hostname = Environment.MachineName;
            string architecture = Environment.Is64BitOperatingSystem ? "x64" : "x86";
            string os = Environment.OSVersion + " " + architecture;

            Uri uri = new Uri( ServerInfo.Server_Function_Path + "adduser.php?name=" + hostname + "&os=" + os);
            var json = Client.DownloadString(uri);
            return JArray.Parse(json);
        } 

        public static JArray LeftMRE()
        {
            //USAGE = removeuser.php
            var json = Client.DownloadString(ServerInfo.Server_Root + "/" + "@/function/removeuser.php");
            return JArray.Parse(json);
        }

        public static bool CheckStatus(JArray json)
        {
            var result = GetJsonString(json, "status", json.Count - 1);
            return result == "success" ? true : false;
        }

        public static string GetMessage(JArray json)
        {
            var mess = GetJsonString(json, "message", json.Count - 1);
            return mess;
        }

        public static string GetJsonString(JArray json, string dataIndex, int arrayIndex)
        {
            var jsonString = json[arrayIndex][dataIndex];
            return jsonString.Value<string>();
        }

        //DATA TYPES NOT WORKING!!!!!!!!!!!!!!!!
        public static T GetJsonData<T>(JArray json, string dataIndex, int arrayIndex) where T : IConvertible
        {
            var jsonString = json[arrayIndex][dataIndex];
            return (T)Convert.ChangeType(jsonString.Value<int>(), typeof(T));
        }
    }
}
