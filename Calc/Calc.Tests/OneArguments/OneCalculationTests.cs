using System;
using Calc.OneArguments;
using NUnit.Framework;

namespace Calc.Tests.OneArguments
{
    public class OneCalculationTests
    {
        [TestCase("button5", typeof(Sin))]
        [TestCase("button9", typeof(Tan))]
        [TestCase("button10", typeof(Binary))]
        [TestCase("button11", typeof(Cube))]
        [TestCase("button6", typeof(Cos))]
        [TestCase("button7", typeof(Sqrt))]
        [TestCase("button8", typeof(Exp))]
        [TestCase("button12", typeof(Log))]
        [TestCase("button14", typeof(Ugoldannogocos))]
        public void FactoryTest(string name, Type type)
        {
            IOneCalculation calc = OneCalculation.CreateCalculator(name);
            Assert.IsInstanceOf(type,calc);
        }
    }
}