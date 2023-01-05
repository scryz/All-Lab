using System;

namespace lab6
{ 

	public class IntegratorRectangle : Integrator
    {
		public IntegratorRectangle()
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
            for (int i = 0; i < N; i++)
            {
                var res = equation.GetValue(x1 + i * h);
                if (Double.IsNaN(res))
                    continue;
                sum = sum + res * h;
            }
            return sum;

        }
        public override string ToString()
        {
            return "Интегратор методом прямоугольников:";
        }
    }
}
	

