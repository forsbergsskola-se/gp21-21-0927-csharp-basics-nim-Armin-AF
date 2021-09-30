using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Hello! Welcome to the Tic Tac Toe Game!");
            
            // Displaying the players
            Console.WriteLine("Player 1: x");
            Console.WriteLine("Player 2: o");
            
            
            // Turn to move
            Console.WriteLine("It is player 1 ( x ) turn. Select a number between 1 1nd 9:");
            
            
            // The display

            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9 ");
            
            // Player input

            string playerInput = Console.ReadLine();



        }
    }
}
