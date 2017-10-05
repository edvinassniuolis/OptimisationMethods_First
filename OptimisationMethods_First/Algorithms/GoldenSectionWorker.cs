using OptimisationMethods_First.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OptimisationMethods_First.Algorithms
{
    public class GoldenSectionWorker
    {
        private readonly double _epsilon;
        private double _left, _right;
        private readonly double _r;
        private double _answer;
        private double _x1, _x2;
        private readonly List<double> _xList, _fxList;

        public GoldenSectionWorker(double epsilon, double left, double right)
        {
            _epsilon = epsilon;
            _left = left;
            _right = right;
            _r = (Math.Sqrt(5) - 1) / 2;
            _xList = new List<double>();
            _fxList = new List<double>();

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _answer = (_right - _left) / 2;
            _x1 = _right - (_r * _answer);
            _x2 = _left + (_r * _answer);

            Check();
        }

        private void Check()
        {


            if (FunctionHolder.GetAimFunctionResult(_x2) < FunctionHolder.GetAimFunctionResult(_x1))
            {
                _left = _x1;
                _answer = _right - _left;
                _x1 = _x2;
                _x2 = _left + (_r * _answer);
                _xList.Add(_answer);
                _fxList.Add(FunctionHolder.GetAimFunctionResult(_answer));
                CheckAnswerValidation();


            }
            else
            {
                _right = _x2;

                _answer = _right - _left;
                _x2 = _x1;
                _x1 = _right - (_r * _answer);
                _xList.Add(_answer);
                _fxList.Add(FunctionHolder.GetAimFunctionResult(_answer));
                CheckAnswerValidation();
            }
        }

        private void CheckAnswerValidation()
        {


            if (_answer < _epsilon)
            {


                for (int i = 0; i < _xList.Count; i++)
                {
                    Debug.WriteLine($"i = {i}\n" +
                                    $"x = {String.Format("{0:F16}", _xList.ElementAt(i))}\n" +
                                    $"F(x) = {String.Format("{0:F16}", _fxList.ElementAt(i))}\n");
                }
                Debug.WriteLine($"x = {_xList.ElementAt(_xList.Count - 1)}\n" +
                                $"answer is {FunctionHolder.GetAimFunctionResult(_answer)}\n");
            }
            else
            {
                Check();
            }
        }
    }
}
