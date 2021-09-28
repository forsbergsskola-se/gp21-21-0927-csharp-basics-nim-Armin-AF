using System;

namespace P7Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           // The operation is: add 7 to 5, multiply the result with 3, subtract 6 from that, divide that result by 1.2 
            double number = (((5+7)*3)-6)/(1.2);
            // Take the remainder after division with 17 from that and convert it to int.
            int finalNumber = Convert.ToInt32(number%17);
            Console.WriteLine(finalNumber);
            
            // I could just do it this way. But I wanted to practice and experience a bit of conversion.
            // Anyway, this is the better code.

            double secondWayNumber = ((((5 + 7) * 3) - 6) / (1.2)) % 17;
            Console.WriteLine(secondWayNumber);
        }

        
            
    }
}
