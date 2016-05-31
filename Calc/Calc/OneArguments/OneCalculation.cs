using System;

namespace Calc.OneArguments
{
    /// <summary>
    /// Factory for functions with one arguments
    /// </summary>
    public static class OneCalculation
    {
        public static IOneCalculation CreateCalculator(string calculationName)
        {
            switch (calculationName)
            {
                case "button5":
                    return new Sin();
                case "button9":
                    return new Tan();
                case "button10":
                    return new Binary();
                case "button11":
                    return new Cube();
                case "button6":
                    return new Cos();
                case "button7":
                    return new Sqrt();
                case "button8":
                    return new Exp();
                case "button12":
                    return new Log();
                case "button14":
                    return new Ugoldannogocos();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}