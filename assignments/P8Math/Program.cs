using System;

namespace P8Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your first number:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me your second number:");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Max: "+ Math.Max(first, second));
            Console.WriteLine("Min: "+ Math.Min(first, second));
            Console.WriteLine("The square root of first number is :"+ Math.Sqrt(first));
            Console.WriteLine("The square root of second number is :"+ Math.Sqrt(second));
            Console.WriteLine("The absolute value of first number is :"+ Math.Abs(first));
            Console.WriteLine("The absolute value of second number is :"+ Math.Abs(second));
            Console.WriteLine("Round value of first number is :"+ Math.Round(first));
            Console.WriteLine("Round value of second number is :"+ Math.Round(second));
            Console.WriteLine("Rounded to the lower integer value of first number is :"+ Math.Floor(first));
            Console.WriteLine("Rounded to the lower integer value of second number is :"+ Math.Floor(second));
            Console.WriteLine("Rounded to the higher integer value of first number is :"+ Math.Ceiling(first));
            Console.WriteLine("Rounded to the higher integer value of second number is :"+ Math.Ceiling(second));
            Console.WriteLine("The first number value to the power of the second number is :"+ Math.Pow(first, second));








            


        }
    }
}
