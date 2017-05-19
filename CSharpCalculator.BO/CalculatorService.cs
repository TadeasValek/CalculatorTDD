using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {
        public static String ParseInput(string previousInput, string currentInput)
        {
            //return int.Parse(previousInput + currentInput).ToString();
            return Convert.ToString(int.Parse(previousInput + currentInput));
        }

    }
}
