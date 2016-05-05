using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculationName)
        {
           switch(calculationName){
           case "button1":
              return new Add();
	       case "button2":
              return new Substraction();
           case "button3":
              return new ClassMultiply();
           case "button4":
              return new ClassDivision();
           case "button13":
              return new Atan();
           case "button14":
              return new Vozvedenievdannuyustepen_();
           case "button15":
              return new Ostatokotdelenia();
              break;
	       default:
		   throw new Exception("Неизвестная операция");
          }
        }
    }
}
