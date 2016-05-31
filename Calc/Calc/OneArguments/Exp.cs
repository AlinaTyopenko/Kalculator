using System;

namespace Calc.OneArguments
{
   public class Exp:IOneCalculation
   {
       /// <summary>
       /// Function returns e raised to the specified power
       /// </summary>
       /// <param name="first">
       /// Input one argument on the first
       /// </param>
       /// <returns>
       /// The number e raised to the power first
       /// </returns>
       public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
