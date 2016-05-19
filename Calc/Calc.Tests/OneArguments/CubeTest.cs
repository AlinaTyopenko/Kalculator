using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class CubeTests
    {
        [TestCase(2, 8)]
        [TestCase(1, 1)]

        public void CubeTest(double first, double expected)
        {
            IOneCalculation calculator = new Cube();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
