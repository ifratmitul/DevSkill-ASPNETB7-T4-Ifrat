using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            if (new Regex(@"^(?:\+?88)?01[135-9]\d{8}$").IsMatch(mobileNumber))
            {
                return true;
            }
            return false;
        }
    }
}
