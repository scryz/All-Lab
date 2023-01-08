using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Zadanie3
    {
        public int zadanie3 (int years)
        {

            if (years < 0 || years == 0)
            {
                throw new ArgumentException();
            }
            if (years % 4 != 0 || (years % 100 == 0 && years % 400 != 0))
            {
                return 365;
            }
            return 366;
        }
    }
}
