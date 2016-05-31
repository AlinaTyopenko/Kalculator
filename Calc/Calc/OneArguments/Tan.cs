using System;

namespace Calc.OneArguments
{
    public class Tan : IOneCalculation
    {
        /// <summary>
        /// Operation returns the tan of the specified angle
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// Result of tan angle
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
