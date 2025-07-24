using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class calculator
    {
        public double firstNum;
        public double secondNum;

        public calculator()
        {
        }
        public double Addition(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public double Subtraction(double firstNum, double secondNum) {
            return firstNum - secondNum; 
        }
        public double Product(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double Division(double firstNum, double secondNum)
        {
            if(secondNum != 0)
            {
                return firstNum / secondNum;
            }
            else
            {
                return double.NaN;
            }
        }
    }
}
