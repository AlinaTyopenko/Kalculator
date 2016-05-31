using System;

namespace Calc.OneArguments
{
   public class Sin:IOneCalculation
    {
       /// <summary>
        /// Function returns the sine of the specified angle
       /// </summary>
       /// <param name="first">
       /// Input one argument on the first
       /// </param>
       /// <returns>
        /// The sine of first
       /// </returns>
       public double Calculate(double first)
       {
           return Math.Sin(first);
       }
    }
}
