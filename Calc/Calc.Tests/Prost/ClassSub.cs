using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class SubTest
    {
        [Test]
        public void SubTest4()
        {
            ITwoArgumentsCalculator calculator = new Substraction();
            double result = calculator.Calculate(16, 8);
            Assert.AreEqual(8, result);
        }
    }
}