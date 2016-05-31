using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.TwoArguments
{
   public class Atan:ITwoArgumentsCalculator
    {
       /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers
       /// </summary>
       /// <param name="first">
        /// Input one argument on the first
       /// </param>
       /// <param name="second">
        /// Input one argument on the secon
       /// </param>
       /// <returns>
        /// An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane.
       /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Atan2(first, second);
        }
    }
}
