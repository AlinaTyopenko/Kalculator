using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]

        public void ExpTest(double first, double expected)
        {
            IOneCalculation calculator = new Exp();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}