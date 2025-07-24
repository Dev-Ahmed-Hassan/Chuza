using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Magical_Duel_Challenge
{
    internal class Stats
    {
        public string name;
        public float damage;
        public string description;
        public float penetration;
        public float cost;
        public float heal;

        public Stats(float damage, float penetration, float heal, float cost, string description)
        {
            this.damage = damage;
            this.penetration = penetration;
            this.cost = cost;
            this.heal = heal;
            this.cost = cost;
            this.description = description;
        }


    }

}
