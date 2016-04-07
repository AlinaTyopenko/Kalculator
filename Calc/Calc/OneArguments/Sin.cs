using System;

namespace Calc.OneArguments
{
   public class Sin:IOneCalculation
    {
       public double Calculate(double first)
       {
           return Math.Sin(first);
       }
    }
}
