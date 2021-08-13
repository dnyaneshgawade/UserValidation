using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string MOBILE = "^[0-9]{1,4}[0-9]{10}$";
        public bool MobileValidate(string mobile)
        {
            return Regex.IsMatch(mobile, MOBILE);
        }
    }
}
