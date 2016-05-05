using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SimpleTest()
        {
            ITwoArgumentsCalculator calculator = new Add();
            double result = calculator.Calculate(2,3);
            Assert.AreEqual(5, result);
        }
    }
}