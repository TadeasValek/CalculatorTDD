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
            string[] allowedCharacters = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] operators = new string[] { "+", "-", "*", "/" };


            if (operators.Contains(previousInput.Substring(previousInput.Length - 1)))
                  if (operators.Contains(currentInput))
                        return ("0");
                  else
                        if (int.TryParse(currentInput, out intCheck))
                            return Convert.ToString((previousInput + currentInput));
                        else return ("0");

            else if (operators.Contains(currentInput))
                    if (previousInput == null)
                        return ("0");
                    else
                        return Convert.ToString(previousInput + currentInput);

             else   if (int.TryParse(currentInput, out intCheck))
                        if (allowedCharacters.Contains(previousInput.Substring(previousInput.Length - 1)))
                            return Convert.ToString(previousInput + currentInput);
                        else return ("0");
             else return ("0");

        }

    }
}
