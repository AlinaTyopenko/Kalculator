using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.OneArguments
{
   public class Ugoldannogocos:IOneCalculation
    {
       /// <summary>
        /// Operation of arc cosine of first
       /// </summary>
       /// <param name="first">
        /// Input one argument on the first
       /// </param>
       /// <returns>
        /// Returns the angle whose cosine is the specified number
       /// </returns>
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
