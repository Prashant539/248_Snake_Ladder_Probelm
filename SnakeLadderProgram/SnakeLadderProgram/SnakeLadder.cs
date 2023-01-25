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
            int dice = 0;
            int roll = 0;
            Console.WriteLine("The Position of the Player is: " + position1);
            do
            {
                roll++;
                Random random = new Random();
                dice = random.Next(1, 7);
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
                if(position1 > 100)
                {
                    position1 = 0;
                }
                Console.WriteLine("The Playr position is: " + position1);
                Console.WriteLine("The dice has been rolled " + roll + " times till now");

            } while (position1 < 100);
            Console.WriteLine($"The dice has been rolled " + roll + " times to reach 100");
        }
    }
}



            
    

        
        
    