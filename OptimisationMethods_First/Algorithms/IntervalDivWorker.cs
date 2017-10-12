using OptimisationMethods_First.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OptimisationMethods_First.Algorithms
{
    public class IntervalDivWorker
    {
        private readonly double _epsilon;
        private readonly List<double> _xList, _fxList;
        private double _left, _right;
        private double _x1, _x2, _xm;
        private double _answ;


        public IntervalDivWorker(double epsilon, double left, double right)
        {
            _epsilon = epsilon;
            _left = left;
            _right = right;
            _xList = new List<double>();
            _fxList = new List<double>();

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _xm = (_left + _right) / 2;
            _answ = _right - _left;

            AssignX1X2();
        }

        private void AssignX1X2()
        {
            _x1 = _left + (_answ / 4);
            _x2 = _right - (_answ / 4);

            Check();
        }

        private void Check()
        {
            if (FunctionHolder.GetAimFunctionResult(_x1) < FunctionHolder.GetAimFunctionResult(_xm))
            {
                _right = _xm;
                _xm = _x1;

                CheckAnswerValidation();

            }
            else if (FunctionHolder.GetAimFunctionResult(_x2) < FunctionHolder.GetAimFunctionResult(_xm))
            {
                _left = _xm;
                _xm = _x2;

                CheckAnswerValidation();
            }
            else
            {
                _left = _x1;
                _right = _x2;

                CheckAnswerValidation();
            }
        }

        private void CheckAnswerValidation()
        {
            _answ = _right - _left;

            _fxList.Add(FunctionHolder.GetAimFunctionResult(_xm));
            _xList.Add(_xm);

            if (_answ < _epsilon)
            {
                for (int i = 1; i < _fxList.Count; i++)
                {
                    Debug.WriteLine($"i = {i}\n" +
                                    $"x = {String.Format("{0:F16}", _xList.ElementAt(i))}\n" +
                                    $"F(x) = {String.Format("{0:F16}", _fxList.ElementAt(i))}\n" +
                                    $"____________________________________________________________");
                }

                Debug.WriteLine($"x = {_xList.ElementAt(_xList.Count - 1)}\n" +
                                $"fmin =  {FunctionHolder.GetAimFunctionResult(_xm)}");
            }
            else
            {
                AssignX1X2();
            }
        }
    }
}
