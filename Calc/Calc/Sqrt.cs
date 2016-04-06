﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Sqrt : IThreeCalculation
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}