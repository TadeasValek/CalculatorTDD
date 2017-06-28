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
            string[] operators = new string[] { "+", "-", "*", "/" };

            if (operators.Contains(previousInput))
                if (operators.Contains(currentInput))
                    return Convert.ToString(previousInput);
                else
                    return Convert.ToString(previousInput + currentInput);

            else
                if (operators.Contains(currentInput))
                        if (previousInput == null)
                        return ("0");
                else
                    return Convert.ToString(previousInput + currentInput);

                    if (int.TryParse(previousInput, out intCheck))
                        if (int.TryParse(currentInput, out intCheck))
                             return Convert.ToString(int.Parse(previousInput + currentInput));
                        else return previousInput;
                else return ("0");

        }

    }
}
