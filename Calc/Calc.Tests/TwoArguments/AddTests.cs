using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2,3,5)]
        [TestCase(100, 500, 600)]
        [TestCase(100000000, 300000000, 400000000)]
        [TestCase(-200, 300, 100)]
        public void AddTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Add();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}