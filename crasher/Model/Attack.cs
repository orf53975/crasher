using crasher.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public class Attack
    {
        public int Id { get; set; } = -1;
        public string Url { get; set; } = "none";
        public AttackType Mode { get; set; } = AttackType.HttpFlood;
        public int Time { get; set; } = 60; //seconds
        
        /**
         * Metodo costruttore che definisce un attacco ad un obbiettivo.
         * **/
        public Attack(string url, AttackType mode,int id)
        {
            Mode = mode;
            Url = url;
            Id = id;
        }

        public Attack(string url, string mode, int time, int id)
        {
            Mode = AttackHelper.StringToAttackType(mode);
            Url = url;
            Time = time;
            Id = id;
        }

        public Attack(string url, AttackType mode, int time,int id)
        {
            Mode = mode;
            Url = url;
            Time = time;
            Id = id;
        }


        /**
         * Metodo che starta l'attacco desiderato
         * **/
        public void Start()
        {
            if (Mode == AttackType.HttpFlood)
                Attacks.HttpFlood.Start(this);
            else if (Mode == AttackType.PodAttack)
                Attacks.PodAttack.Start(this);
        }

        /**
         * Metodo che ferma l'attacco
         * **/
        public void Stop()
        {
            if (Mode == AttackType.HttpFlood)
                Attacks.HttpFlood.Stop();
            else if (Mode == AttackType.PodAttack)
                Attacks.PodAttack.Stop();
        }


        public override string ToString()
        {
            return String.Format("Id: {0}, Url: {1}, Mode: {2}, Time: {3}",Id,Url,Mode.ToString(),Time.ToString());
        }
    }
}
