using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LAB7
{
    public class Zadanie4
    {
        public bool z4(string input)
        {
            if (input == null)
                throw new ArgumentException();
            Regex r3 = new Regex(@"^\w+([_\-\.]\w+)*@(\w+\.)+[a-zA-Z]{2}$");
            if (r3.IsMatch(input))
                return true;
            else return false;
        }
    }
}
