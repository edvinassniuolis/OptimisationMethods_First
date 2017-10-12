using System;

namespace OptimisationMethods_First.Functions
{
    public static class FunctionHolder
    {
        public static double GetAimFunctionResult(double x)
        {
            return (Math.Pow(x, 4) / 9) - 1;
        }

        //public static double GetAimFunctionResult(double x)
        //{
        //    return Math.Pow((x * x - 3), 2) - 1;
        //}

        public static double GetFunctionDerivative(double x)
        {
            return (4 * Math.Pow(x, 3)) / 9;
        }

        public static double GetFunctionDoubleDerivative(double x)
        {
            return (4 * Math.Pow(x, 2)) / 3;
        }
    }
}
