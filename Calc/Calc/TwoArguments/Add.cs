namespace Calc.TwoArguments
{
    public class Add:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }

    }
}

