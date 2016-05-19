using System;
using Calc.OneArguments;
using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    public class TwoArgumentFactoryTests
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
            ITwoArgumentsCalculator calc = TwoArguments.CreateCalculator(name);
            Assert.IsInstanceOf(type, calc);
        }
    }
}