﻿using System;

namespace P5Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            string numberString = Convert.ToString(number);
            Console.WriteLine(numberString);
            numberString = "56.3";
            Console.WriteLine(Convert.ToInt32(numberString));
        }
    }
}