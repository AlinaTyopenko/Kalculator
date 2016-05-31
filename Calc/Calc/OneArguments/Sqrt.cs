using System;

namespace Calc.OneArguments
{
    public class Sqrt : IOneCalculation
    {
        /// <summary>
        /// Returns the square root of a specified number
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// square root of first
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
