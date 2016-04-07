using System;

namespace Calc.OneArguments
{
    public class Cos: IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
