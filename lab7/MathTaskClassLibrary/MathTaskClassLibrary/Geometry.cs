using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int CalculateArea(int a, int b)
        {
            if (a < b || b < 0) throw new System.ArgumentException();
            return a * b;
        }
    }
}
