using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    [TestFixture]
    public class UgoldannogocosTests
    {
        [TestCase(1, 0)]

        public void UgoldannogocosTest(double first, double expected)
        {
            IOneCalculation calculator = new Ugoldannogocos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}