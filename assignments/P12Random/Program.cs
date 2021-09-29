using System;

namespace P12Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pass me a seed (integer).");
            int seed = Convert.ToInt32(Console.ReadLine());
            Random number = new Random(seed);
            int randomNumber = (int)number.Next();
            Console.WriteLine(randomNumber);

            Random number2 = new Random();
            Console.WriteLine("Three random integers between 0 and 5:");
            for (int i = 0; i < 3; i++)
            {
                int randomNumber2 = (int)number2.Next(0, 5);
                Console.WriteLine(randomNumber2);
            }

            Random number3 = new Random();
            Console.WriteLine("Three random numbers between 0,0 and 0,5:");
            for (int i = 0; i < 3; i++)
            {
                double randomNumber2 = number3.NextDouble() * 0.5;
                Console.WriteLine(randomNumber2);
            }
            
            Random number4 = new Random();
            Console.WriteLine("Three random numbers between 0,2 and 0,7:");
            for (int i = 0; i < 3; i++)
            {
                double randomNumber2 = number4.NextDouble() * 0.5 + 0.2;
                Console.WriteLine(randomNumber2);
            }

            Console.WriteLine("Give me a crit chance between 0,0 and 1,0: ");
            double crit = Convert.ToDouble(Console.ReadLine());
            Random random4 = new Random();
            for (int i = 0; i < 5; i++)
            {
                double critChance = random4.NextDouble() * crit;
                if (critChance < 0.3)
                {
                    Console.WriteLine("No Crit!");

                }
                else
                {
                    Console.WriteLine("Crit!");
                }
            }

        }
    }
}
