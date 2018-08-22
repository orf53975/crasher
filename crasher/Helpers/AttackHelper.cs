using crasher.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Helpers
{
    public static class AttackHelper
    {
        public static AttackType StringToAttackType(string mode)
        {
            string formattedMode = mode.ToLower().Trim(new char[] {' '});
            if (formattedMode.Equals("httpflood"))
            {
                return AttackType.HttpFlood;
            }
            else if(formattedMode.Equals("pingofdeath(pod)"))
            {
                return AttackType.PodAttack;
            }
            else if (formattedMode.Equals("udpflood"))
            {
                throw new NotImplementedException();
            }
            else if (formattedMode.Equals("icmp(ping)flood"))
            {
                throw new NotImplementedException();
            }
            else if (formattedMode.Equals("synflood"))
            {
                throw new NotImplementedException();
            }
            else if (formattedMode.Equals("slowloris"))
            {
                throw new NotImplementedException();
            }

            //If the string doesn't match with any of the attacks type sets the default mode (http flood)
            return AttackType.HttpFlood;
        }
    }
}
