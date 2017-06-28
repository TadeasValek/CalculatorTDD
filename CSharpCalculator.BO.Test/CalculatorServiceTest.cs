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
        [TestCase("a", "4", "0")] //handle attempt to enter non-numeric value as previous input. Method should return "0" in this case.
        [TestCase("1", "a", "1")] //Handle attempt to enter non-numeric value as new input. Method should return previous input in the case it contains valid value.
        [TestCase("0", "5", "5")] //when previous input contains "0" (default) value. return only new input in the case it contains valid value. -> valid value
        [TestCase("0", "n", "0")] //when previous input contains "0" (default) value. return only new input in the case it contains valid value. -> invalid value
        [TestCase("/", "4", "/4")]
        [TestCase("/", "25", "/25")]
        [TestCase("4", "/", "4/")]
        [TestCase("40", "/", "40/")]
        [TestCase("40", "*", "40*")]
        [TestCase("/", "111", "/111")]
        [TestCase("445", "*", "445*")]
        [TestCase("/", "*", "0")]
        [TestCase("444/", "*", "0")]
        [TestCase("555/", "/", "0")]
        [TestCase("555/", "444", "555/444")]

        public void ParseInputTest(string previousInput, string currentInput, string expectedResult)
        {
            string actualResult = CalculatorService.ParseInput(previousInput, currentInput);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
