using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]

        public void CosTest(double first, double expected)
        {
            IOneCalculation calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}