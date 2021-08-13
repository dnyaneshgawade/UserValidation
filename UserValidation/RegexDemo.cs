using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string PASSWORD_CASE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public bool PasswordCase2Validate(string pass2)
        {
            return Regex.IsMatch(pass2, PASSWORD_CASE2);
        }
    }
}
