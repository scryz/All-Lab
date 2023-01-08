using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Zadanie4
    {
        public int zadanie4(string emails)
        {
            if(emails == null)
            {
                    throw new ArgumentException();
            }
            Regex regex3 = new Regex(@"^(([aA-zZ]+[-_][aA-zZ0-9]+)|([aA-zZ0-9]+))[@]((\w+)|(\w[\w-]+))[.]\w+$");
            if (regex3.IsMatch(emails))
            {
                return 1;
            }
            else return 0;
        }
    }
}
