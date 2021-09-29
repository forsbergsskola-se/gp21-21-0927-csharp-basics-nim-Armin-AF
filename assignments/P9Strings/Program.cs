using System;

namespace P9Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("In which year you have been born?");
            int yearBirth = Convert.ToInt32(Console.ReadLine());
            int age = 2021 - yearBirth;
            Console.WriteLine($"Hi {firstName} {lastName}! You are {age} years old. ");

        }
    }
}
