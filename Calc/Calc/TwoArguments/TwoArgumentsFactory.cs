using System;

namespace Calc.TwoArguments
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculationName"></param>
        /// <returns></returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculationName)
        {
           switch(calculationName){
           case "button1":
              return new Add();
		      break;
	       case "button2":
              return new Substraction();
		      break;
           case "button3":
              return new ClassMultiply();
              break;
           case "button4":
              return new ClassDivision();
           case "button13":
              return new Atan();
           case "button16":
              return new Ostatokotdelenia();
              break;
	       default:
		  throw new Exception("Неизвестная операция");
          }
        }
    }
}
