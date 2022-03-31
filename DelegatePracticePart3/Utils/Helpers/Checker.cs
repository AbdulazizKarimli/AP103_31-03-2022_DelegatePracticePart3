using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils.Helpers
{
    public static class Checker
    {
        public static bool EmailChecker(string email)
        {
            Regex regex = new Regex("^\\S+@\\S+\\.\\S+$"); 
            return regex.IsMatch(email);
        }
    }
}
