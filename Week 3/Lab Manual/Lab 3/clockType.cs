using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds; 
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }

        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }

        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void incrementSecond()
        {
            seconds++;
        }

        public void incrementhours()
        {
            hours++;
        }

        public void incrementminutes()
        {
            minutes++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }

        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
