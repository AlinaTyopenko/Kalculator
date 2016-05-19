using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(6, 3, 2)]
        [TestCase(100000, 50000, 2)]
        [TestCase(-10, 5, -2)]
        [TestCase(1000000000, 1000000000, 1)]
        public void DivisionTet(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new ClassDivision();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}