using System;

namespace lab6
{

    public class IntegratorTrapezoid : Integrator
    {
        public IntegratorTrapezoid()
        {

        }
        public override double Integrate(Equation equation, double x1, double x2, int N = 100)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница должна быть больше левой!");
            }
            double h = (x2 - x1) / N;
            double sum = 0;


            double sumf = ((equation.GetValue(x1 * h) + equation.GetValue(x2 * h))) / 2;


            for (int i = 1; i < N; i++)
            {

                var r = equation.GetValue(x1 + i * h);
                sum += (Double.IsNaN(r) ? 0 : r);
            }
            return h * (sum + sumf);

        }
        public override string ToString()
        {
            return "Интегратор методом трапеций";
        }
    }
}