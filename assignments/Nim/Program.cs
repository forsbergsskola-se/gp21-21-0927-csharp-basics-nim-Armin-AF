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
            Console.WriteLine("RULES: ");
            Console.WriteLine("The game begins with placing 24 matches in a pile.");
            Console.WriteLine("Players take turns to draw matches");
            Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less).");
            Console.WriteLine("The Player who has to take the last match will lose!");
            Console.WriteLine("  ");
            
            int matches = 24;
            
            while (matches > 0)
            {
                for (int i = 0; i <= matches; i++)
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
                        Random random = new Random();
                        int aiPick = random.Next(1, 4);
                        matches = matches - playerPick;
                        if (matches <= 0)
                        {
                            Console.WriteLine(@"                                                                                                                                                                                                                                     
 _     _  _____  _     _      _       _____    _    _______ 
| |   | |/ ___ \| |   | |    | |     / ___ \  | |  (_______)
| |___| | |   | | |   | |    | |    | |   | |  \ \  _____   
 \_____/| |   | | |   | |    | |    | |   | |   \ \|  ___)  
   ___  | |___| | |___| |    | |____| |___| |____) ) |_____ 
  (___)  \_____/ \______|    |_______)_____(______/|_______)
                                                            
                                                                     
                                                                      ");
                            break;
                        }
                        Console.WriteLine("AI picks: " + aiPick );
                        matches = matches - aiPick;
                        if (matches <= 0)
                        {
                            Console.WriteLine(@" 
 _     _  _____  _     _      _  _  _ _____ ______  
| |   | |/ ___ \| |   | |    | || || (_____)  ___ \ 
| |___| | |   | | |   | |    | || || |  _  | |   | |
 \_____/| |   | | |   | |    | ||_|| | | | | |   | |
   ___  | |___| | |___| |    | |___| |_| |_| |   | |
  (___)  \_____/ \______|     \______(_____)_|   |_|
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
            

           
            Console.ReadLine();
        }
    }
}
