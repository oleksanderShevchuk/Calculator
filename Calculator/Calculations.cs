using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        //public event EventHandler<string> IsEvent;
        public decimal Addition(decimal firstValue, decimal secondValue)
        {
            //IsEvent?.Invoke(this, "Addition");
            return firstValue + secondValue;
        }
        public decimal Subtraction(decimal firstValue, decimal secondValue)
        {
            //IsEvent?.Invoke(this, "Subtraction");
            return firstValue - secondValue;
        }
        public decimal Multiplication(decimal firstValue, decimal secondValue)
        {
            //IsEvent?.Invoke(this, "Multiplication");
            return firstValue * secondValue;
        }
        public decimal Division(decimal firstValue, decimal secondValue)
        {
            //IsEvent?.Invoke(this, "Division");
            return Math.Round((firstValue / secondValue), 10, MidpointRounding.AwayFromZero);
        }
        public decimal Sqrt(decimal Value)
        {
            //IsEvent?.Invoke(this, "Division");
            return (decimal)Math.Round(Math.Sqrt((double)Value), 10, MidpointRounding.AwayFromZero);
        }
        public decimal Power(decimal Value, decimal power)
        {
            //IsEvent?.Invoke(this, "Division");
            return (decimal)Math.Pow((double)Value, (double)power);
        }
        public decimal Factorial(decimal Value)
        {
            if (Value == 1)
            {
                return 1;
            }
            return Value * Factorial(Value - 1);
        }
    }
}