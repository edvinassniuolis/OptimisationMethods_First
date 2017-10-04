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
        //    return (x * x - 2 * x);
        //}
    }
}
