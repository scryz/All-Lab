using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{

    public class Zadanie1
    {
        public string zadanie1(int n)
        {

            if (n <= 1 || n >= 26)
            {
                throw new ArgumentException();
            }
            char[] arr = Enumerable.Range(0, n).Select((a, i) => (char)('A' + i)).ToArray();

            return new string(arr);

        }
    }
}
