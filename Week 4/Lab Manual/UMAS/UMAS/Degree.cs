using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class Degree
    {
        public string name;
        public int duration;
        public int seats;
        public List<Subject> s = new List<Subject>();

        public Degree(string name, int duration, int seats, List<Subject> sub) 
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            this.s = sub;
        }
    }


}
