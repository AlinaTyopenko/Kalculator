namespace Calc.TwoArguments
{
    public class ClassDivision:ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public  double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
