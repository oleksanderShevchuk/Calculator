using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public decimal Addition(decimal firstValue, decimal secondValue)
        {
            return firstValue + secondValue;
        }
        public decimal Subtraction(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }
        public decimal Multiplication(decimal firstValue, decimal secondValue)
        {
            return secondValue * firstValue;
        }
        public decimal Division(decimal firstValue, decimal secondValue)
        {
            return secondValue / firstValue;
        }
    }
}