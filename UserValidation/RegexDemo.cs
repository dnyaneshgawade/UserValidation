﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public const string FIRST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public const string LAST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE = "^[0-9]{1,4}[0-9]{10}$";
        public const string PASSWORD = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).(?=.*[!@#$%^&*?]).{8,}$";

        public string User(string fname,string lname,string email,string mobile,string password)
        {
            if (Regex.IsMatch(fname, FIRST_NAME_RESTRICTION) != true)
            {
                return "sad";
            }

            if (Regex.IsMatch(lname, LAST_NAME_RESTRICTION) != true)
            {
                return "sad";
            }

            if (Regex.IsMatch(email, EMAIL) != true)
            {
                return "sad";
            }
            
            if (Regex.IsMatch(mobile, MOBILE) != true)
            {
                return "sad";
            }

            if (Regex.IsMatch(password, PASSWORD) != true)
            {
                return "sad";
            }
            return "happy";
        }
    }
}
