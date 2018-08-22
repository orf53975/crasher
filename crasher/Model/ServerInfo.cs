using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public class ServerInfo
    {
        //public static string Server_Root { get; private set; } = "http://testingapps.altervista.org";

        public static string Server_Root { get; private set; } = "http://192.168.0.186:8123/mre";
        public static string Server_Function_Path { get; private set; } = ServerInfo.Server_Root + "/main/function/";
    }
}