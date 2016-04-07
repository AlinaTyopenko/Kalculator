using System;

namespace Calc.OneArguments
{
    public class Sqrt : IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
