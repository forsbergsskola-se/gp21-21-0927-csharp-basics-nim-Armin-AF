using System;

namespace P14ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count from 1 to 1000.");
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Count from 200 to 100.");
            for (int i = 200; i >= 100; i--)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("For-loop that starts at 1024, always divides the number by 2, until it reaches 1, then it stops!");
            for (int i = 1024; i>= 1; i /= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
