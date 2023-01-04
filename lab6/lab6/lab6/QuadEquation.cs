using System;
using System.Windows.Forms;

namespace lab6
{
    public class QuadEquation : Equation
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public QuadEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            double d = b * b - 4 * a * c;
            if (d < 0) { MessageBox.Show("Дискрименант меньше нуля"); }
            if (d == 0) 
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант = 0.\n X = " + x + ".");
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Дискриминант = " + d + ".\n X1 = " + x1 + ".\n X2 = " + x2 + ".");
            }

        }
        public override double GetValue(double x)
        {
            return a * x * x + b * x + c;
        }
    }
}
