using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Arc
{
    internal class course
    {
        public string Code;
        public string CourseTeacher;

        public List<string> EnrolledStudents = new List<string>();


        public course(string code)
        {
            this.Code = code;
        }
        public course(string code, string courseTeacher)
        {
            this.Code = code;
            this.CourseTeacher = courseTeacher;
        }
    }
}
