using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.TwoArguments
{
   public class Atan:ITwoArgumentsCalculator
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="first"></param>
       /// <param name="second"></param>
       /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Atan2(first, second);
        }
    }
}
