using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]


        public void SinTest(double first, double expected)
        {
            IOneCalculation calculator = new Sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}