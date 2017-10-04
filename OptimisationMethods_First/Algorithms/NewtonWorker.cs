using OptimisationMethods_First.Functions;
using System;
using System.Windows.Forms;

namespace OptimisationMethods_First.Algorithms
{
    public class NewtonWorker
    {
        private double _x0, _xk, _xi;
        private readonly double _epsilon;
        private int i;

        public NewtonWorker(double epsilon, double x0)
        {
            _x0 = x0;
            _epsilon = epsilon;
            _xi = _x0;
        }

        private void AssignFirstValue()
        {
            i = 0;
        }

        private void AssignFunction()
        {
            _xk = _xi - (FunctionHolder.GetAimFunctionResult(_xi) / FunctionHolder.GetAimFunctionResult(_xi));
        }

        private void CheckAnswerValidation()
        {
            if (Math.Abs(_xi - _xk) < _epsilon)
            {
                MessageBox.Show($"answer is ");
            }
            else
            {
                _xi++;
                AssignFunction();
            }
        }


    }
}
