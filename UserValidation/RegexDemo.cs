using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string PASSWORD_CASE3 = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{8,}$";
        public bool PasswordCase3Validate(string pass3)
        {
            return Regex.IsMatch(pass3, PASSWORD_CASE3);
        }
    }
}
