using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstract class AttackProxy
    {
        public static string hostname { get; set; } = "localhost";
        public static int port { get; set; } = 80;
    }
}
