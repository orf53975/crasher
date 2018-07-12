using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstract class AttackStats
    {
        public static bool Started { get; set; } = false;
        public static int RequestSent { get; set; } = 0;
        public static int RequestDone { get; set; } = 0;
    }
}
