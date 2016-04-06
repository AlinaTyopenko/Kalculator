using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class FourCalculation
    {
        public static IFourCalculation CreateCalculator(string calculationName)
        {
            switch (calculationName)
            {
                case "button8":
                    return new Exp ();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
