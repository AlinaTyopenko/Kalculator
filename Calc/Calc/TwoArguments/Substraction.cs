﻿namespace Calc.TwoArguments
{
    public class Substraction: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Operation of subtraction
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <param name="second">
        /// Input one argument on the second
        /// </param>
        /// <returns>
        /// Result first - second
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }

    }
}
