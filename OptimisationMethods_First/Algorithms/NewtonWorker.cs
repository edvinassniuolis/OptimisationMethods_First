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
        private readonly List<double> _xList, _fxList;

        public NewtonWorker(double epsilon, double x0)
        {
            _x0 = x0;
            _epsilon = epsilon;
            _xi = _x0;
            _xList = new List<double>();
            _fxList = new List<double>();

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _i = 0;
            AssignFunction();
        }

        private void AssignFunction()
        {
            _xiPlusOne = _xi - (FunctionHolder.GetAimFunctionResult(_xi) / FunctionHolder.GetFunctionDerivative(_xi));

            _xList.Add(_xi);
            _fxList.Add(_xiPlusOne);

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
                                    $"F(x) = {String.Format("{0:F16}", _fxList.ElementAt(i))}\n");
                }
                var temp = _xiPlusOne - (FunctionHolder.GetAimFunctionResult(_xiPlusOne) /
                                         FunctionHolder.GetFunctionDerivative(_xiPlusOne));
                Debug.WriteLine($"ATS:\n" +
                                $"i = {++_i}\n" +
                                $"Xi+1 = {temp}\n" +
                                $"f(Xi+1) = {FunctionHolder.GetAimFunctionResult(temp)}\n");
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
