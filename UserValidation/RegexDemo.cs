using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string LAST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public bool LastNameValidate(string lastName)
        {
            return Regex.IsMatch(lastName, LAST_NAME_RESTRICTION);
        }
    }
}
