using System;

namespace Calc.OneArguments
{
    public class Cos: IOneCalculation
    {
        /// <summary>
        /// Function returns the cosine of the specified angle
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// The cosine of first
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
