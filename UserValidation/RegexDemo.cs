using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string FIRST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public bool FirstNameValidate(string firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME_RESTRICTION);
        }
    }
}
