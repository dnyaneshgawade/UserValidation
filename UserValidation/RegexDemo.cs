﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class RegexDemo
    {
        public static string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public bool MultipleEmail(string[] list)
        {
            foreach (string email in list)
            {
                if (Regex.IsMatch(email, EMAIL) != true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
