using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class DegreeBL
    {
        public string name;
        public int duration;
        public int seats;
        public int subjects;
        public int creditHours;

        public List<SubjectBL> s = new List<SubjectBL>();


        public DegreeBL(string name, int duration, int seats, int subjects)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            this.subjects = subjects;
        }
        public void AddSubject(SubjectBL sub)
        {
            s.Add(sub);
            creditHours += sub.CreditHours;
        }

        public bool CheckSubjectByCode(int code)
        {
            bool flag = false;
            foreach (SubjectBL sub in s)
            {
                if (code == sub.SubjectCode)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
