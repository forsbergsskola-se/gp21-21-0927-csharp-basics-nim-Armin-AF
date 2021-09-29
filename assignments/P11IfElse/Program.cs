using System;
using System.Runtime.InteropServices;

namespace P11IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 0 && age < 12)
            {
                Console.WriteLine("You are a child!");
            } 
            else if(age <19)
            {
                Console.WriteLine("You are a teenager!");
            }
            else
            {
                Console.WriteLine("You are a grown-up!");
            }
        }
    }
}
