using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(1, 0)]


        public void LogTest(double first, double expected)
        {
            IOneCalculation calculator = new Log();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}