using System;

namespace Calc.TwoArguments
{
    public class Ostatokotdelenia:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by another specified number.
        /// </summary>
        /// <param name="first">
        /// Input one argument on the first
        /// </param>
        /// <param name="second">
        /// Input one argument on the second
        /// </param>
        /// <returns>
        /// A number equal to x - (y Q), where Q is the quotient of x / y rounded to the nearest integer
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.IEEERemainder(first, second);
        }
    }
}
