using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class MultTestD
    {
        [TestCase(2, 3, 6)]
        [TestCase(100, 500, 50000)]
        public void AddTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new ClassMultiply();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}