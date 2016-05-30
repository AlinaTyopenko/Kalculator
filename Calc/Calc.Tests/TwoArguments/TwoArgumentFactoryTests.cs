using System;
using Calc.OneArguments;
using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{

    public class TwoArgumentFactoryTests
    {
        [TestCase("button1", typeof(Add))]
        [TestCase("button2", typeof(Substraction))]
        [TestCase("button3", typeof(ClassMultiply))]
        [TestCase("button4", typeof(ClassDivision))]
        [TestCase("button13", typeof(Atan))]
        [TestCase("button16", typeof(Ostatokotdelenia))]

        public void FactoryTest(string name, Type type)
        {
            ITwoArgumentsCalculator calc = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calc);
        }
    }
}