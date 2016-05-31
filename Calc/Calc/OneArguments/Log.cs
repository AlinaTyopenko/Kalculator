using System;

namespace Calc.OneArguments
{
    public class Log:IOneCalculation
    {
        /// <summary>
        /// Operation of logarithm
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// Returns the natural (base e) logarithm of a specified number first
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
