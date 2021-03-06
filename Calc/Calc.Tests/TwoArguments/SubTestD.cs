﻿using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class SubstractionTest
    {
        [TestCase(2, 3, -1)]
        [TestCase(12345, 2345, 10000)]
        [TestCase(1000000, 1000000, 0)]
        [TestCase(-500, 300, -800)]
        public void SubstactionTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Substraction();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}