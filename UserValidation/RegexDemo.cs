using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string PASSWORD_CASE1 = "^[A-Za-z0-9!@#$%&]{8,}$";
        public bool PasswordCase1Validate(string pass1)
        {
            return Regex.IsMatch(pass1, PASSWORD_CASE1);
        }
    }
}
