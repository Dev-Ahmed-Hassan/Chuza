using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS
{
    internal class SubjectDL
    {
        static List<SubjectBL> list = new List<SubjectBL>();
        
        static public void AddSubject(SubjectBL s)
        {
            list.Add(s);    
        }
        static public bool CheckSubjectByCode(int code)
        {
            bool flag = false;
            foreach (SubjectBL s in list)
            {
                if (code == s.SubjectCode)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        
    }
}
