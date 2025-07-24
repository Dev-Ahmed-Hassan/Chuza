using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UMAS
{
    internal class StudentBL
    {
        public string name;
        public int age;
        public float FSCMarks;
        public float ECATMarks;
        public List<DegreeBL> preferences = new List<DegreeBL>();
        public List<SubjectBL> RegisteredSubjects = new List<SubjectBL>();
        public DegreeBL degree;

        public StudentBL(string name, int age, float f, float e)
        {
            this.name = name;
            this.age = age;
            this.FSCMarks = f;
            this.ECATMarks = e;
        }

        
    }
}
