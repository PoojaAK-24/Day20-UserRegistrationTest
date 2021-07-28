using System;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationTest
{
    public class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Program program = new Program();
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To UserRegistration");
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(program.FirstNameVal(FirstName));
        }
        public bool FirstNameVal(string fname)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(fname); ;
        }
    }
}
