using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crasher.Model;

namespace crasher.Helpers
{
    public class NetHelper
    {
        public static byte[] RandomFillPackets(int size){
            Byte[] packet = new Byte[size];
            Random rnd = new Random();
            rnd.NextBytes(packet);
            return packet;
        }

       //WORK IN PROGRESS
       /*
       public static void SetTORProxy()
       {
            //SETS PROXY USING TOR NETWORK, REQUIRES TOR STARTED AND CONNECTED
            AttackProxy.hostname = "127.0.0.1";
            AttackProxy.port = 9150;
       }
       */
       
    }
}
