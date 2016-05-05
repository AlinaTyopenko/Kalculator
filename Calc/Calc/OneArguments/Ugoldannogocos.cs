﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.OneArguments
{
   public class Ugoldannogocos:IOneCalculation
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
