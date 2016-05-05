using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class MultTest
    {
        [Test]
        public void SimpleTest2()
        {
            ITwoArgumentsCalculator calculator = new ClassMultiply();
            double result = calculator.Calculate(7, 8);
            Assert.AreEqual(56, result);
        }
    }
}