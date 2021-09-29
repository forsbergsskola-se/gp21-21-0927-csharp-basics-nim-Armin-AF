using System;
using System.Diagnostics.SymbolStore;

namespace P1Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isChild = age > 0 && age < 12;
            bool isTeenager = age > 13 && age < 19;
            bool isGrownup = age > 19;
            Console.WriteLine("You are a child: " + isChild);
            Console.WriteLine("You are a teenager: " + isTeenager);
            Console.WriteLine("You are a grown-up: " + isGrownup);


        }
            
    }
}
