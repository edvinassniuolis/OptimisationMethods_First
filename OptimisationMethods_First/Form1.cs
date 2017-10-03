using System;
using System.Windows.Forms;

namespace OptimisationMethods_First
{
    public partial class mainForm : Form
    {
        private double[] interval;

        private static readonly double epsilon = 0.0001;

        private double L;
        private double left = 0, right = 10;
        private double xCenter, x1, x2, fx1, fx2, fxcenter;
        private double answer;

        public mainForm()
        {
            InitializeComponent();
        }

        private void intervalDivButton_Click(object sender, EventArgs e)
        {
            L = right - left;
            xCenter = GetMin(left, right);

            DefineIntervalPoints();
            Checkx1Validations();
        }

        private void goldenDivButton_Click(object sender, EventArgs e)
        {

        }

        private void newtonButton_Click(object sender, EventArgs e)
        {

        }

        private double GetAimFunction(double x)
        {
            return (Math.Pow(x, 2)) / 8;
        }

        private double GetMin(double a, double b)
        {
            return (b - a) / 2;
        }

        private void CountTotalAnswer()
        {
            if ((right - left) < epsilon)
            {
                answer = right - left;
            }
            else
            {
                DefineIntervalPoints();
            }
        }

        private void DefineIntervalPoints()
        {
            x1 = left + L / 4;
            x2 = right - L / 4;

            fx1 = GetAimFunction(x1);
            fx2 = GetAimFunction(x2);
        }

        private void Checkx1Validations()
        {
            if (fx1 < GetAimFunction(xCenter))
            {
                right = xCenter;
                xCenter = x1;
                CountTotalAnswer();
            }
        }
    }
}
