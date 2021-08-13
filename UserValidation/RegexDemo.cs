using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string PASSWORD_CASE4 = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).(?=.*[!@#$%^&*?]).{8,}$";
        public bool PasswordCase4Validate(string pass4)
        {
            return Regex.IsMatch(pass4, PASSWORD_CASE4);
        }
    }
}
