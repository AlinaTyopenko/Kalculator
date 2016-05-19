using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplyTests
    {
        [TestCase(2, 3, 6)]
        [TestCase(100, 500, 50000)]
        [TestCase(-10, 3, -30)]
        [TestCase(1000000, -10000, -10000000000)]
        public void MultiplyTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new ClassMultiply();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}