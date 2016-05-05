using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Binary : IOneCalculation
    {
        public double Calculate(double first)
        {
            string s = Convert.ToString((int)first, 2);
            return Convert.ToInt32(s);
        }
    }
}
