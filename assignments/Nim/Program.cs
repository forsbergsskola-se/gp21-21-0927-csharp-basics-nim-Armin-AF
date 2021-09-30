using System;
using System.Threading.Tasks.Dataflow;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
            Console.WriteLine(@"RULES: 
            1-The game begins with placing 24 matches in a pile.
            2-Players take turns to draw matches.
            3-Each player may draw 1,2 or 3 matches (not more or less).
            4-The Player who has to take the last match will lose!
              ");
            
            int matches = 24;
            
            while (matches > 0)
            {
                for (int i = 0; i < matches; i++)
                {
                    Console.Write("|");
                }
                Console.WriteLine( "  " + matches);
                Console.WriteLine("How many matches would you like to draw?");
                
                int playerPick;
                string playerPickString = Console.ReadLine();
                bool errorCheck = int.TryParse(playerPickString, out playerPick);

                if (errorCheck)
                {
                    if (playerPick > 3 | playerPick < 1)
                    { 
                        Console.WriteLine("You can pick 1, 2 or 3 matches!(Input 1, 2 or 3) try again!");
                    }
                    else
                    {
                        matches = matches - playerPick;
                        if (matches <= 0)
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
                            break;
                        }
                        int aiPick;
                        if (matches == 2)
                        {
                            aiPick = 1;
                        }

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
                            Random random = new Random();
                            aiPick = random.Next(1, 4);
                        }
                        Console.WriteLine("AI picks: " + aiPick );
                        matches = matches - aiPick;

                        if (matches <= 0)
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
