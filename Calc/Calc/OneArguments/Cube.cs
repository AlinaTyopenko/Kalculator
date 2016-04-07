using System;

namespace Calc.OneArguments
{
    public class Cube: IOneCalculation
    {
        public double Calculate(double first) 
        {
            return Math.Pow(first, 3);        
        }
    }
}
