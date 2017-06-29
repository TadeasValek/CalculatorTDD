using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {


        private static String inputValidation(string testedInput)
        {
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] operators = new char[] { '+', '-', '*', '/' };

                char y;
                int operatorsCounter = 0;

                for (int i = 0; i < testedInput.Length; i++)
                {
                    y = testedInput[i];
                    if (!((operators.Contains(y)) || (numbers.Contains(y))))
                    {
                        return "invalid";
                    }
                //Verify only 1 operator
                if (operators.Contains(y))
                        {
                        operatorsCounter++;
                        if ((operatorsCounter) > 1)
                            {
                            return "moreOperators";
                            }
                        }
                }
            return "valid";
        }


        public static String ParseInput(string previousInput, string currentInput)
        {

            if ((inputValidation(previousInput + currentInput).Equals("valid")))
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
            else if (((inputValidation(currentInput).Equals("invalid"))) 
                    && ((inputValidation(previousInput).Equals("valid"))))
            {
                return (previousInput);
            }
            else
            {
                return "0";
            }

        }


    }
}