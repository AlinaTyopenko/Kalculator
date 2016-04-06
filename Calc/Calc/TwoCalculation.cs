using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class TwoCalculation
    {
        public static ITwoCalculation CreateCalculator(string calculationName)
        {
            switch (calculationName)
            {
                case "button6":
                    return new Cos();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
