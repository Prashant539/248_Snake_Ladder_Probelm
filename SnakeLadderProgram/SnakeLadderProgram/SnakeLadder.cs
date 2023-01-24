using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    public class SnakeLadder
    {
        public const int LADDER = 1, SNAKE = 2;
        public void Game()
        {

            int position1 = 0;
            Console.WriteLine("The Position of the Player is: " + position1);
            do
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("The number got by dice roll is: " + dice);
                Random random1 = new Random();
                int option = random1.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        position1 += dice;
                        Console.WriteLine("The Player climb the Ladder");
                        break;
                    case SNAKE:
                        position1 -= dice;
                        if (position1 < 0)
                        {
                            Console.WriteLine("The Player bit by Snake");
                            position1 = 0;
                        }
                        else
                        {
                            Console.WriteLine("The Player bit by Snake");
                        }
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("The Playr position is: " + position1);
                

            } while (position1 < 100);
        }
    }
}



            
    

        
        
    