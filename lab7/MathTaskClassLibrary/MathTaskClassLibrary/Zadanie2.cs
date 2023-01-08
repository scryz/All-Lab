using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Zadanie2
    {
        public double[] zadanie2(double a, double b, double c, double x1, double x2, double D)
        {
            if (a == 0)
            {
                throw new ArgumentException();
            }
            D = (b * b) - (4 * a * c);

            if (D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                return new double[1] { x1 };
            }

            if(D < 0)
            {
                return new double[0];
            }

            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return new double[2] {x1, x2};
            }

        }
    }
}
