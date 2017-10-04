using OptimisationMethods_First.Functions;
using System;
using System.Windows.Forms;

namespace OptimisationMethods_First.Algorithms
{
    public class GoldenSectionWorker
    {
        private readonly double _epsilon;
        private double _left, _right;
        private readonly double _r;
        private double _answer;
        private double _x1, _x2, _fx1, _fx2;

        public GoldenSectionWorker(double epsilon, double left, double right)
        {
            _epsilon = epsilon;
            _left = left;
            _right = right;
            _r = (Math.Sqrt(5) - 1) / 2;

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _answer = _right - _left;
            _x1 = _right - (_r * _answer);
            _x2 = _left + (_r * _answer);

            _fx1 = FunctionHolder.GetAimFunctionResult(_x1);
            _fx2 = FunctionHolder.GetAimFunctionResult(_x2);

            Check();
        }

        private void Check()
        {
            if (_fx2 < _fx1)
            {
                _left = _x1;
                _answer = _right - _left;
                _x1 = _x2;
                _x2 = _left + (_r * _answer);
                _fx2 = FunctionHolder.GetAimFunctionResult(_x2);
                CheckAnswerValidation();
            }
            else
            {
                _right = _x2;
                _answer = _right - _left;
                _x2 = _x1;
                _x1 = _right - (_r * _answer);
                _fx1 = FunctionHolder.GetAimFunctionResult(_x1);
                CheckAnswerValidation();
            }
        }

        private void CheckAnswerValidation()
        {
            if (_answer < _epsilon)
            {
                MessageBox.Show($"answer is {_answer}");
            }
            else
            {
                Check();
            }
        }
    }
}
