using System;
using System.Threading.Tasks.Dataflow;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  

            Console.WriteLine(@"          
                                                                                                                                                                                                     
NNNNNNNN        NNNNNNNN     IIIIIIIIII     MMMMMMMM               MMMMMMMM                       GGGGGGGGGGGGG               AAA               MMMMMMMM               MMMMMMMMEEEEEEEEEEEEEEEEEEEEEE
N:::::::N       N::::::N     I::::::::I     M:::::::M             M:::::::M                    GGG::::::::::::G              A:::A              M:::::::M             M:::::::ME::::::::::::::::::::E
N::::::::N      N::::::N     I::::::::I     M::::::::M           M::::::::M                  GG:::::::::::::::G             A:::::A             M::::::::M           M::::::::ME::::::::::::::::::::E
N:::::::::N     N::::::N     II::::::II     M:::::::::M         M:::::::::M                 G:::::GGGGGGGG::::G            A:::::::A            M:::::::::M         M:::::::::MEE::::::EEEEEEEEE::::E
N::::::::::N    N::::::N       I::::I       M::::::::::M       M::::::::::M                G:::::G       GGGGGG           A:::::::::A           M::::::::::M       M::::::::::M  E:::::E       EEEEEE
N:::::::::::N   N::::::N       I::::I       M:::::::::::M     M:::::::::::M               G:::::G                        A:::::A:::::A          M:::::::::::M     M:::::::::::M  E:::::E             
N:::::::N::::N  N::::::N       I::::I       M:::::::M::::M   M::::M:::::::M               G:::::G                       A:::::A A:::::A         M:::::::M::::M   M::::M:::::::M  E::::::EEEEEEEEEE   
N::::::N N::::N N::::::N       I::::I       M::::::M M::::M M::::M M::::::M               G:::::G    GGGGGGGGGG        A:::::A   A:::::A        M::::::M M::::M M::::M M::::::M  E:::::::::::::::E   
N::::::N  N::::N:::::::N       I::::I       M::::::M  M::::M::::M  M::::::M               G:::::G    G::::::::G       A:::::A     A:::::A       M::::::M  M::::M::::M  M::::::M  E:::::::::::::::E   
N::::::N   N:::::::::::N       I::::I       M::::::M   M:::::::M   M::::::M               G:::::G    GGGGG::::G      A:::::AAAAAAAAA:::::A      M::::::M   M:::::::M   M::::::M  E::::::EEEEEEEEEE   
N::::::N    N::::::::::N       I::::I       M::::::M    M:::::M    M::::::M               G:::::G        G::::G     A:::::::::::::::::::::A     M::::::M    M:::::M    M::::::M  E:::::E             
N::::::N     N:::::::::N       I::::I       M::::::M     MMMMM     M::::::M                G:::::G       G::::G    A:::::AAAAAAAAAAAAA:::::A    M::::::M     MMMMM     M::::::M  E:::::E       EEEEEE
N::::::N      N::::::::N     II::::::II     M::::::M               M::::::M                 G:::::GGGGGGGG::::G   A:::::A             A:::::A   M::::::M               M::::::MEE::::::EEEEEEEE:::::E
N::::::N       N:::::::N     I::::::::I     M::::::M               M::::::M                  GG:::::::::::::::G  A:::::A               A:::::A  M::::::M               M::::::ME::::::::::::::::::::E
N::::::N        N::::::N     I::::::::I     M::::::M               M::::::M                    GGG::::::GGG:::G A:::::A                 A:::::A M::::::M               M::::::ME::::::::::::::::::::E
NNNNNNNN         NNNNNNN     IIIIIIIIII     MMMMMMMM               MMMMMMMM                       GGGGGG   GGGGAAAAAAA                   AAAAAAAMMMMMMMM               MMMMMMMMEEEEEEEEEEEEEEEEEEEEEE
                                                                                                                                                                                                     
            
                              ");
            // TODO: Great use of multi-line comments! :)
            // Printing the rules and instructions for the player.
            Console.WriteLine(@"RULES: 
            1-The game begins with placing 24 matches in a pile.
            2-Players take turns to draw matches.
            3-Each player may draw 1,2 or 3 matches (not more or less).
            4-The Player who has to take the last match will lose!
              ");
            
            // Defining the total number of matches.
            int matches = 24;
            // We start a while loop and break it whenever we have a winner!
            while (matches > 0)
            {
                for (int i = 0; i < matches; i++)
                {
                    // Printing out the visual presentation of matches with a for loop. 
                    Console.Write("|");
                }
                Console.WriteLine( "  " + matches);
                Console.WriteLine("How many matches would you like to draw?");
                
                // Player input (Number of matches at each round) + Checking the input errors 
                int playerPick;
                string playerPickString = Console.ReadLine();
                
                // If errorCheck is true we can control the validity of number entry.
                if (int.TryParse(playerPickString, out playerPick)) // TODO: I would put TryX-Methods directly into if-statements. It might not be as clear to a beginner, but it's quite clear to anyone with experience :)
                {
                    // TODO: Nice way of doing error checks!
                    if (playerPick > 3 | playerPick < 1)
                    { 
                        Console.WriteLine("You can pick 1, 2 or 3 matches!(Input 1, 2 or 3) try again!");
                    }
                    else
                    {
                        matches = matches - playerPick;
                        // TODO: All of these if-elses are pretty deeply nested, but it's as good as it gets without the use of Methods, so all fine :)
                        if (matches <= 0) //Player takes the last match and lose the game.
                        {
                            Console.WriteLine(@"                                                                                                                                                                                                                                     
 __    __                              __                                 __     
/\ \  /\ \                            /\ \                               /\ \    
\ `\`\\/'/  ___    __  __             \ \ \        ___     ____     __   \ \ \   
 `\ `\ /'  / __`\ /\ \/\ \             \ \ \  __  / __`\  /',__\  /'__`\  \ \ \  
   `\ \ \ /\ \L\ \\ \ \_\ \             \ \ \L\ \/\ \L\ \/\__, `\/\  __/   \ \_\ 
     \ \_\\ \____/ \ \____/              \ \____/\ \____/\/\____/\ \____\   \/\_\
      \/_/ \/___/   \/___/                \/___/  \/___/  \/___/  \/____/    \/_/
                                                                     
                                                                      ");
                            // Breaking the loop after clear result.
                            break;
                        }
                        // Setting up the AI. [(matches - 3) - 4(x)]>>> It means matches=24 (24-3)=21 -4x {21, 17, 13, 9, 5} are places to keep in order to win. is the winning formula.
                        // If AI starts the match it is always the winner. Unbeatable AI.
                        // By giving the player the chance to start we basically give them the chance to win! If we want the AI to be always the winner we simply let the AI start with the formula.
                        // If we want a very easy and dumb AI we can only assign the aiPick as random and ignore the formula.
                        int aiPick;
                        if (matches == 2)
                        {
                            aiPick = 1;
                        }
                        // TODO: I feel like there should be a solution using MODULO (%) here... :)
                        else if (matches == 3 || matches == 7 || matches == 11 || matches == 15 || matches == 19 || matches == 23)
                        {
                            aiPick = 2;
                        }
                        else if (matches == 4 || matches == 8 || matches == 12 || matches == 16 || matches == 20 )
                        {
                            aiPick = 3;
                        }
                        else if (matches == 6 || matches == 10 || matches == 14 || matches == 18 || matches == 22)
                        {
                            aiPick = 1;
                        }
                        else
                        {
                            //Random value for {21,17,13,9,5} since the winning spots are taken and the outcome is the same regardless of our choice. 
                            // TODO: Good idea! Can at least try to confuse the player :D
                            Random random = new Random();
                            aiPick = random.Next(1, 4);
                        }
                        Console.WriteLine("AI picks: " + aiPick );
                        matches = matches - aiPick;

                        if (matches <= 0) //AI takes the last match and player wins the game.
                        {
                            Console.WriteLine(@" 

                                                                                 
 __    __                              __      __                     __     
/\ \  /\ \                            /\ \  __/\ \    __             /\ \    
\ `\`\\/'/  ___    __  __             \ \ \/\ \ \ \  /\_\     ___    \ \ \   
 `\ `\ /'  / __`\ /\ \/\ \             \ \ \ \ \ \ \ \/\ \  /' _ `\   \ \ \  
   `\ \ \ /\ \L\ \\ \ \_\ \             \ \ \_/ \_\ \ \ \ \ /\ \/\ \   \ \_\ 
     \ \_\\ \____/ \ \____/              \ `\___x___/  \ \_\\ \_\ \_\   \/\_\
      \/_/ \/___/   \/___/                '\/__//__/    \/_/ \/_/\/_/    \/_/                                                                                 

                                                    ");
                            break;
                        } 
                        
                    }
                }
                else
                {
                    // In case the player enters a none integer input.
                    Console.WriteLine("Invalid input! Type 1,2 or 3.");
                }
                

            }

            Console.WriteLine(@"
                                           
                                            " );
            Console.WriteLine("Thank You for playing!");
            
            Console.ReadLine();
        }
    }
}

// Marc's solution
/*using System;

class Program {
    static void Main() {
        Random random = new Random();
        int matches = 24;
        int i;

        Console.WriteLine("Match has started.");
        
        while (matches > 0) {
            
            // ======= AI PHASE ===============
            
            // Print matches to the console
            i = 0;
            while (i < matches) {
                Console.Write('|');
                i++;
            }
            Console.WriteLine($" ({matches})");
            
            // AI Draws
            int aiMatches = 1; // cheap ai
            aiMatches = random.Next(1, 4); // "fun" ai
            aiMatches = (matches-1) % 4; // impossible ai
            
            
            // We limit the number of matches to the amount available.
            aiMatches = Math.Min(aiMatches, matches);
            Console.WriteLine($"The ai draws {aiMatches} match.");
            matches -= aiMatches;

            // Check AI Lose
            if (matches == 0) {
                Console.WriteLine("You win!");
            }
            
            
            // ======= PLAYER PHASE ===============
            // Print matches to the Console
            i = 0;
            while (i < matches) {
                Console.Write('|');
                i++;
            }
            Console.WriteLine($" ({matches})");
            
            // Player Draws
            Console.WriteLine("How many matches do you want to draw? (1-3)");
            string playerNumberInput = Console.ReadLine();
            int playerNumber = Convert.ToInt32(playerNumberInput);
            // We limit the number of matches to the amount that the rules allow.
            playerNumber = Math.Clamp(playerNumber, 1, 3);
            // We limit the number of matches to the amount available.
            playerNumber = Math.Min(playerNumber, matches);
            matches -= playerNumber;

            // Check for Player Lose
            if (matches == 0) {
                Console.WriteLine("You lose!");
                break;
            }
        }

        Console.WriteLine("Match has ended.");
    }
}
*/