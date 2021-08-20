using System;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regexDemo = new RegexDemo();
            Console.WriteLine(regexDemo.User("Dnayanesh","Gawade","dnyanesh@gmail.com","919000000000", "Dd@#nyhnesh@12"));
        }
    }
}
