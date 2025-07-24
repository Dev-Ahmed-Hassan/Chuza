using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class DegreeDL
    {
        static List<DegreeBL> list = new List<DegreeBL>();

        static public DegreeBL searchDeg(string name)
        {
            foreach(DegreeBL deg in list)
            {
                if (deg.name == name)
                {
                    return deg;
                }
            }
            return null;
        }
        
        static public void AddDegree(DegreeBL s)
        {
            list.Add(s);
        }
        static public bool CheckDegreeByName(string name)
        {
            bool flag = false;
            foreach (DegreeBL s in list)
            {
                if (name == s.name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
