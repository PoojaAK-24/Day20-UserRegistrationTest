using System;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationTest
{
    public class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Program p = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_UserRegistration_RegeEx");
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(p.FirstNameVal(FirstName));
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine(p.LastNameVal(LastName));
        }
        public bool FirstNameVal(string first_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(first_name); ;
        }

        public bool LastNameVal(string last_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            bool validate = rg.IsMatch(last_name);
            return validate;
        }
    }
}
