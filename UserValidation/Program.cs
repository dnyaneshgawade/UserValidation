﻿using System;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            Console.WriteLine(regexDemo.EmailValidate("dnyanesh@gmail.com"));
        }
    }
}
