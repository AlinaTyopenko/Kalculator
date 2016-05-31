using System;

namespace Calc.OneArguments
{
    public class Binary : IOneCalculation
    {
        /// <summary>
        /// The translation operation in the binary number system
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// Returns the number of first is translated into a binary number system
        /// </returns>
        public double Calculate(double first)
        {
            string s = Convert.ToString((int)first, 2);
            return Convert.ToInt32(s);
        }
    }
}
