using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class BinaryTests
    {
        [TestCase(2, 010)]
        [TestCase(1,001)]

        public void BinaryTest(double first, double expected)
        {
            IOneCalculation calculator = new Binary();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}