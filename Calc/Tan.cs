using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Tan : IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
