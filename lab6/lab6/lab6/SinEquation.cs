using System;
using System.Windows.Forms;

namespace lab6
{
    internal class SinEquation : Equation
    {
        public readonly double a;

        public SinEquation(double a)
        {
            this.a = a;

            double y = Math.Sin(a);
            MessageBox.Show("Sin(a * x) / x = " + y + ".");
        }

        public override double GetValue(double x)
        {
            return Math.Sin(a * x) / x;
        }
    }
}