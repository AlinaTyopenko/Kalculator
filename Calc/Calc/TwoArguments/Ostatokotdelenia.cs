using System;

namespace Calc.TwoArguments
{
    public class Ostatokotdelenia:ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.IEEERemainder(first, second);
        }
    }
}
