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
            int intCheck;

            if (int.TryParse(previousInput, out intCheck))
                if (int.TryParse(currentInput, out intCheck))
                    return Convert.ToString(int.Parse(previousInput + currentInput));
                else return previousInput;
            else
                return ("0");

        }

    }
}
