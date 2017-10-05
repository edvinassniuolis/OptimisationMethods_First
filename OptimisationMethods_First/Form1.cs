using OptimisationMethods_First.Algorithms;
using System;
using System.Windows.Forms;

namespace OptimisationMethods_First
{
    public partial class mainForm : Form
    {
        private double[] interval;

        private static readonly double epsilon = 0.0001;
        private static readonly double tEpsilon = 0.001;

        private double left = 0, right = 10;
        private double tLeft = 0, tRight = 5;
        private double x0 = 5;

        public mainForm()
        {
            InitializeComponent();
        }

        private void intervalDivButton_Click(object sender, EventArgs e)
        {
            var interval = new IntervalDivWorker(epsilon, left, right);
            // var tinterval = new IntervalDivWorker(tEpsilon, tLeft, tRight);
        }
        private void goldenDivButton_Click(object sender, EventArgs e)
        {
            var golden = new GoldenSectionWorker(epsilon, left, right);
        }
        private void newtonButton_Click(object sender, EventArgs e)
        {
            var newton = new NewtonWorker(epsilon, x0);
        }

    }
}
