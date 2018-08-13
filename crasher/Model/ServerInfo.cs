using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public class ServerInfo
    {
        public static string Server_Root { get; private set; } = "http://localhost:8123/mre";
        public static string Server_Function_Path { get; private set; } = ServerInfo.Server_Root + "/@/function/";
    }
}
