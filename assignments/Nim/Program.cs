using System;
using System.Threading.Tasks.Dataflow;

namespace Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"          
          _____                    _____                    _____                            _____                    _____                    _____                    _____          
         /\    \                  /\    \                  /\    \                          /\    \                  /\    \                  /\    \                  /\    \         
        /::\____\                /::\    \                /::\____\                        /::\    \                /::\    \                /::\____\                /::\    \        
       /::::|   |                \:::\    \              /::::|   |                       /::::\    \              /::::\    \              /::::|   |               /::::\    \       
      /:::::|   |                 \:::\    \            /:::::|   |                      /::::::\    \            /::::::\    \            /:::::|   |              /::::::\    \      
     /::::::|   |                  \:::\    \          /::::::|   |                     /:::/\:::\    \          /:::/\:::\    \          /::::::|   |             /:::/\:::\    \     
    /:::/|::|   |                   \:::\    \        /:::/|::|   |                    /:::/  \:::\    \        /:::/__\:::\    \        /:::/|::|   |            /:::/__\:::\    \    
   /:::/ |::|   |                   /::::\    \      /:::/ |::|   |                   /:::/    \:::\    \      /::::\   \:::\    \      /:::/ |::|   |           /::::\   \:::\    \   
  /:::/  |::|   | _____    ____    /::::::\    \    /:::/  |::|___|______            /:::/    / \:::\    \    /::::::\   \:::\    \    /:::/  |::|___|______    /::::::\   \:::\    \  
 /:::/   |::|   |/\    \  /\   \  /:::/\:::\    \  /:::/   |::::::::\    \          /:::/    /   \:::\ ___\  /:::/\:::\   \:::\    \  /:::/   |::::::::\    \  /:::/\:::\   \:::\    \ 
/:: /    |::|   /::\____\/::\   \/:::/  \:::\____\/:::/    |:::::::::\____\        /:::/____/  ___\:::|    |/:::/  \:::\   \:::\____\/:::/    |:::::::::\____\/:::/__\:::\   \:::\____\
\::/    /|::|  /:::/    /\:::\  /:::/    \::/    /\::/    / ~~~~~/:::/    /        \:::\    \ /\  /:::|____|\::/    \:::\  /:::/    /\::/    / ~~~~~/:::/    /\:::\   \:::\   \::/    /
 \/____/ |::| /:::/    /  \:::\/:::/    / \/____/  \/____/      /:::/    /          \:::\    /::\ \::/    /  \/____/ \:::\/:::/    /  \/____/      /:::/    /  \:::\   \:::\   \/____/ 
         |::|/:::/    /    \::::::/    /                       /:::/    /            \:::\   \:::\ \/____/            \::::::/    /               /:::/    /    \:::\   \:::\    \     
         |::::::/    /      \::::/____/                       /:::/    /              \:::\   \:::\____\               \::::/    /               /:::/    /      \:::\   \:::\____\    
         |:::::/    /        \:::\    \                      /:::/    /                \:::\  /:::/    /               /:::/    /               /:::/    /        \:::\   \::/    /    
         |::::/    /          \:::\    \                    /:::/    /                  \:::\/:::/    /               /:::/    /               /:::/    /          \:::\   \/____/     
         /:::/    /            \:::\    \                  /:::/    /                    \::::::/    /               /:::/    /               /:::/    /            \:::\    \         
        /:::/    /              \:::\____\                /:::/    /                      \::::/    /               /:::/    /               /:::/    /              \:::\____\        
        \::/    /                \::/    /                \::/    /                        \::/____/                \::/    /                \::/    /                \::/    /        
         \/____/                  \/____/                  \/____/                                                   \/____/                  \/____/                  \/____/         
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
