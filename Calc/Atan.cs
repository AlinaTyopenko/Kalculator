using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Atan:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Atan2(first, second);
        }
    }
}
