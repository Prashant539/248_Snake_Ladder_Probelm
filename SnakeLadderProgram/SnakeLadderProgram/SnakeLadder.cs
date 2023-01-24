using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    public class SnakeLadder
    {
        public void Game()
        {
            int position = 0;
            Console.WriteLine("The Position of the Player is: " + position);
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("The number got by dice roll is: " + dice);
        }
    }
}
