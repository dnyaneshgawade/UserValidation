using System;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            Console.WriteLine(regexDemo.PasswordCase4Validate("dDd@#nyh9nesh"));
        }
    }
}
