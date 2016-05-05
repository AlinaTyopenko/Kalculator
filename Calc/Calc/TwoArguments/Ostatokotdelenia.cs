using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.TwoArguments
{
    class Ostatokotdelenia:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.IEEERemainder(first, second);
        }
    }
}
