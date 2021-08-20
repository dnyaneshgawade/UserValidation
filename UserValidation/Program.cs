using System;

namespace UserValidation
{
    class Program
    {
        public static string[] list = { "dnyanesh@gmail.com", "d903@gmail.com" };
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            Console.WriteLine(regexDemo.MultipleEmail(list));
        }
    }
}
