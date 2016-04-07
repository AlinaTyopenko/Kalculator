using System;

namespace Calc.OneArguments
{
   public class Exp:IOneCalculation
   {
       public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
