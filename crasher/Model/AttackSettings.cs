using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstract class AttackSettings
    {
        public static string Url { get; set; } = "none";
        public static AttackType Mode { get; set; } = AttackType.HttpFlood;
        public static int Time { get; set; } = 60; //seconds

        public static bool Threading { get; set; } = false;
        public static int Threads { get; set; } = 10;
        public static int PacketSize { get; set; } = 2048;
    }
}
