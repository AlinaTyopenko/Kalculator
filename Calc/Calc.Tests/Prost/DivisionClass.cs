using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class DivTest
    {
        [Test]
        public void DivTest3()
        {
            ITwoArgumentsCalculator calculator = new ClassDivision();
            double result = calculator.Calculate(16, 8);
            Assert.AreEqual(2, result);
        }
    }
}