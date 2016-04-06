using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class OneCalculation
    {
        public static IOneCalculation CreateCalculator(string calculationName)
        {
            switch (calculationName)
            {
                case "button5":
                    return new Sin();
                case "button9":
                    return new Tan();
                case "button10":
                    return new Binary();
                case "button11":
                    return new Cube();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}