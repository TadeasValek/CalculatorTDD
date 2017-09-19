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

            char[] operands = new char[] { '+', '-', '*', '/' };
            char y = previousInput[previousInput.Length - 1];
            char z = currentInput[0];
            char w = previousInput[0];

            //float result = calculateResult("9999/556");

            //erase if c pressed
            if (currentInput.Contains("c"))
                return "0";

            //if previousInput is operand, change it if another operator is used
            if (operands.Contains(y) && operands.Contains(z))
            {
                return ((previousInput.Remove((previousInput.Length - 1), 1)) + currentInput);
            }
            else

            // if operand is the first char in previousInput, ignore it
            if (operands.Contains(w))
            {
                return ((previousInput.Remove((0), 1)) + currentInput);
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
                if (currentInput == "=")
                {
                    return Convert.ToString(calculateResult(previousInput));
                }

                else return (previousInput);
                
            }
            else
                return "0";
            }

        

        private static bool inputValidation(string testedInput)
        {
            return testedInput.All(x => char.IsNumber(x) || x == '+' || x == '-' || x == '*' || x == '/');
        }

            private static float calculateResult(string calculateInput)
        {
            int inputLength = calculateInput.Length;

            if (calculateInput.IndexOf('+') > 0)
            {
                float a = Convert.ToSingle(calculateInput.Remove(calculateInput.IndexOf('+'), inputLength - calculateInput.IndexOf('+')));
                float b = Convert.ToSingle(calculateInput.Remove(0, calculateInput.IndexOf('+') + 1));
                //float b = Convert.ToSingle(calculateInput.Remove(0, 2));
                return a + b;
            }
            else if (calculateInput.IndexOf('-') > 0)
            {
                float a = Convert.ToSingle(calculateInput.Remove(calculateInput.IndexOf('-'), inputLength - calculateInput.IndexOf('-')));
                float b = Convert.ToSingle(calculateInput.Remove(0, calculateInput.IndexOf('-') + 1));
                return a - b;
            }
            else if (calculateInput.IndexOf('*') > 0)
            {
                float a = Convert.ToSingle(calculateInput.Remove(calculateInput.IndexOf('*'), inputLength - calculateInput.IndexOf('*')));
                float b = Convert.ToSingle(calculateInput.Remove(0, calculateInput.IndexOf('*') + 1));
                return a * b;
            }
            else if (calculateInput.IndexOf('/') > 0)
            {
                float a = Convert.ToSingle(calculateInput.Remove(calculateInput.IndexOf('/'), inputLength - calculateInput.IndexOf('/')));
                float b = Convert.ToSingle(calculateInput.Remove(0, calculateInput.IndexOf('/') + 1));
                return a / b;
            }
            else return 0;
        }


    }
}