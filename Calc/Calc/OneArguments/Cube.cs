using System;

namespace Calc.OneArguments
{
    public class Cube: IOneCalculation
    {
        /// <summary>
        /// Operation of a third power 
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <returns>
        /// The number first raised to the power 3
        /// </returns>
        public double Calculate(double first) 
        {
            return Math.Pow(first, 3);        
        }
    }
}
