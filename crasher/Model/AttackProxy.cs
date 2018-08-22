using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstract class AttackProxy
    {
        public static string Hostname { get; set; } = "localhost";
        public static int Port { get; set; } = 80;
    }
}
