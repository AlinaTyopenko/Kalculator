using System;

namespace Calc.OneArguments
{
    public class Tan : IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
