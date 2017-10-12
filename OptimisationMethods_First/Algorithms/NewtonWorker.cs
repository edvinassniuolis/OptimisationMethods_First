using OptimisationMethods_First.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OptimisationMethods_First.Algorithms
{
    public class NewtonWorker
    {
        private double _x0, _xiPlusOne, _xi;
        private readonly double _epsilon;
        private int _i;
        private readonly List<double> _xList, _xiPlusOneList;

        public NewtonWorker(double epsilon, double x0)
        {
            _x0 = x0;
            _epsilon = epsilon;
            _xi = _x0;
            _xList = new List<double>();
            _xiPlusOneList = new List<double>();

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _i = 0;
            AssignFunction();
        }

        private void AssignFunction()
        {
            _xiPlusOne = _xi - (FunctionHolder.GetFunctionDerivative(_xi) / FunctionHolder.GetFunctionDoubleDerivative(_xi));

            _xList.Add(_xi);
            _xiPlusOneList.Add(_xiPlusOne);

            CheckAnswerValidation();
        }

        private void CheckAnswerValidation()
        {
            if (Math.Abs(_xi - _xiPlusOne) < _epsilon)
            {
                for (int i = 1; i < _xList.Count; i++)
                {
                    Debug.WriteLine($"i = {i}\n" +
                                    $"x = {String.Format("{0:F16}", _xList.ElementAt(i))}\n" +
                                    $"F(x) = {String.Format("{0:F16}", _xiPlusOneList.ElementAt(i))}\n" +
                                    $"____________________________________________________________\n");
                }

                Debug.WriteLine($"ATS:" +
                                $"x = {String.Format("{0:F16}", _xiPlusOneList.ElementAt(_xList.Count - 1))}\n" +
                                $"F(x) = {String.Format("{0:F16}", FunctionHolder.GetAimFunctionResult(_xiPlusOneList.ElementAt(_xiPlusOneList.Count - 1)))}\n" +
                                $"____________________________________________________________\n");
            }
            else
            {
                _i++;
                _xi = _xiPlusOne;
                AssignFunction();
            }
        }


    }
}
