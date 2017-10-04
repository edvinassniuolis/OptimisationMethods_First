using OptimisationMethods_First.Functions;
using System.Windows.Forms;

namespace OptimisationMethods_First.Algorithms
{
    public class IntervalDivWorker
    {
        private readonly double _epsilon;
        private double _left, _right;
        private double _xm, _fxm;
        private double _x1, _x2, _fx1, _fx2;
        private double _answ;

        public IntervalDivWorker(double epsilon, double left, double right)
        {
            _epsilon = epsilon;
            _left = left;
            _right = right;

            AssignFirstValue();
        }

        private void AssignFirstValue()
        {
            _xm = (_left + _right) / 2;
            _answ = _right - _left;
            _fxm = FunctionHolder.GetAimFunctionResult(_xm);

            AssignX1X2();
        }

        private void AssignX1X2()
        {
            _x1 = _left + (_answ / 4);
            _x2 = _right - (_answ / 4);
            _fx1 = FunctionHolder.GetAimFunctionResult(_x1);
            _fx2 = FunctionHolder.GetAimFunctionResult(_x2);

            Check();
        }

        private void Check()
        {
            if (_fx1 < _fxm)
            {
                _right = _xm;
                _xm = _x1;
                CheckAnswerValidation();
            }
            else if (_fx2 < _fxm)
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

            if (_answ < _epsilon)
            {
                MessageBox.Show($"Answer is: {_answ}");
                MessageBox.Show($"left = {_left}\n" +
                                $"right = {_right}\n" +
                                $"xm = {_xm}\n" +
                                $"fx1 = {_fx1}\n" +
                                $"fx2 = {_fx2}\n");
            }
            else
            {
                AssignX1X2();
            }
        }
    }
}
