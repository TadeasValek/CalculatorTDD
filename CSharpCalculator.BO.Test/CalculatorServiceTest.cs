using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator.BO;

namespace CSharpCalculator.BO.Test
{
    [TestFixture]
    public class CalculatorServiceTest
    {
        [TestCase("1", "5", "15")]
        [TestCase("2", "5", "25")]
        [TestCase("0", "5", "5")]
        [TestCase("1", "a", "5")] //expected is previous input
        [TestCase("a", "5", "0")] //expected is 0

        public void ParseInputTest(string previousInput, string currentInput, string expectedResult)
        {

            string actualResult = CalculatorService.ParseInput(previousInput, currentInput);
            Assert.That(actualResult, Is.EqualTo(expectedResult));            
            //string Result = "WrongInput123";

            //int intResult;
            //bool isResultInt = int.TryParse(Result,out intResult);
            //Assert.That(isResultInt, Is.Not.False);

        }
    }
}
