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

            char[] operators = new char[] { '+', '-', '*', '/' };
            char y = previousInput[previousInput.Length - 1];
            char z = currentInput[0];

            float result = calculateResult("9999/556");

            if (operators.Contains(y) && operators.Contains(z))
            {
                return ((previousInput.Remove((previousInput.Length - 1), 1)) + currentInput);
            }
            else

                if (inputValidation(previousInput + currentInput))
            {
                if (previousInput == "0")
                {
                    return (currentInput);
                }
                else
                {
                    return (previousInput + currentInput);
                }
            }
            else if (!inputValidation(currentInput) && ((inputValidation(previousInput))))
            {
                return (previousInput);
            }
            else
            {
                return "0";
            }

        }

        private static bool inputValidation(string testedInput)
        {
            return testedInput.All(x => char.IsNumber(x) || x == '+' || x == '-' || x == '*' || x == '/');
        }

       /* public static String calculate()
        {
            long abc = calculateResult(previousInput && currentInput);
        }
        */


            private static float calculateResult(string joinedInput)
        {
            int inputLength = joinedInput.Length;

            if (joinedInput.IndexOf('+') > 0)
            {
                float a = Convert.ToSingle(joinedInput.Remove(joinedInput.IndexOf('+'), inputLength - joinedInput.IndexOf('+')));
                float b = Convert.ToSingle(joinedInput.Remove(0, inputLength - joinedInput.IndexOf('+') + 1));
                return a + b;
            }
            else if (joinedInput.IndexOf('-') > 0)
            {
                float a = Convert.ToSingle(joinedInput.Remove(joinedInput.IndexOf('-'), inputLength - joinedInput.IndexOf('-')));
                float b = Convert.ToSingle(joinedInput.Remove(0, inputLength - joinedInput.IndexOf('-') + 1));
                return a - b;
            }
            else if (joinedInput.IndexOf('*') > 0)
            {
                float a = Convert.ToSingle(joinedInput.Remove(joinedInput.IndexOf('*'), inputLength - joinedInput.IndexOf('*')));
                float b = Convert.ToSingle(joinedInput.Remove(0, inputLength - joinedInput.IndexOf('*') + 1));
                return a * b;
            }
            else if (joinedInput.IndexOf('/') > 0)
            {
                float a = Convert.ToSingle(joinedInput.Remove(joinedInput.IndexOf('/'), inputLength - joinedInput.IndexOf('/')));
                float b = Convert.ToSingle(joinedInput.Remove(0, inputLength - joinedInput.IndexOf('/') + 1));
                return a / b;
            }
            else return 0;
        }


    }
}