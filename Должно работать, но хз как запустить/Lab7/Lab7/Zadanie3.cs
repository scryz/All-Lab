using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    public class Zadanie3
    {
        public bool z3(int year)
        {
            if (year < 0 || year == 0)
                throw new ArgumentException();
            else
            {
                if (DateTime.IsLeapYear(year))
                    return true;
                else return false;
            }
        }
    }
}
