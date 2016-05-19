using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class AtanTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(0, 100, 0)]

        public void AtanTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Atan();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}