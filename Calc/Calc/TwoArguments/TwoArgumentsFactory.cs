﻿using System;

namespace Calc.TwoArguments
{
    public static class TwoArgumentsFactory
    {
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
              break;
	       default:
		   throw new Exception("Неизвестная операция");
          }
        }
    }
}