using System;

namespace Calc.OneArguments
{
    public class Log:IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
