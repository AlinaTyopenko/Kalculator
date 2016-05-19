using System;

namespace Calc.TwoArguments
{
    public class Ostatokotdelenia:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.IEEERemainder(first, second);
        }
    }
}
