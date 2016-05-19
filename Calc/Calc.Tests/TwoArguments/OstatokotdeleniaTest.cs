using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class OstatokotdeleniaTests
    {
        [TestCase(2, 3,-1)]
        [TestCase(100, 50, 0)]
        public void OstatokotdeleniaTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Ostatokotdelenia();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}