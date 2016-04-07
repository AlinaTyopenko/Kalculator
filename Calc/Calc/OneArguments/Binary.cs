using System;

namespace Calc.OneArguments
{
    public class Binary : IOneCalculation
    {
        public double Calculate(double first)
        {
            string s = Convert.ToString((int)first, 2);
            return Convert.ToInt32(s);
        }
    }
}
