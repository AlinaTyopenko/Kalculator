using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(-0, 0)]

        public void TanTest(double first, double expected)
        {
            IOneCalculation calculator = new Tan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}