using System;
using System.Threading.Tasks.Dataflow;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to nim!");
            Console.WriteLine("RULES: ");
            Console.WriteLine("The game begins with placing 24 matches in a pile.");
            Console.WriteLine("Players take turns to draw matches");
            Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less).");
            Console.WriteLine("The Player who has to take last match wins!");
            
            
            int matches = 24;
            
            
            while (matches > 0)
            {
                for (int i = 0; i <= matches; i++)
                {
                    Console.Write("|");
                }
                Console.WriteLine( "  " + matches);
                Console.WriteLine("How many matches would do you like to draw?");
                int playerPick = Convert.ToInt32(Console.ReadLine());
                

                if (playerPick > 3 | playerPick < 1)
                { 
                    Console.WriteLine("You can pick 1, 2 or 3 matches!(Input 1, 2 or 3) try again!");
                }
                else
                {
                    matches = matches - playerPick;
                    Console.WriteLine("AI picks: " + (4-playerPick) + "!");
                    matches = matches - (4 - playerPick);
                    
                    
                }
            }

            Console.WriteLine("AI win! Better luck next time! Probably not :))))) ");
            Console.ReadLine();
        }
    }
}
