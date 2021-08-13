using System;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            Console.WriteLine(regexDemo.PasswordCase3Validate("dDdnyh9nesh"));
        }
    }
}
