using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(25, 5)]
        [TestCase(144, 12)]
        [TestCase(100, 10)]
        public void SqrtTest(double first, double expected)
        {
            IOneCalculation calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}