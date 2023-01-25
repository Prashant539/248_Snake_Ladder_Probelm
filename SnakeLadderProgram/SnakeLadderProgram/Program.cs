using System;
namespace SnakeLadderProgram
{
    internal class Progrma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake ladder Program ");
            Console.WriteLine("Enter the Number to Perform the Program: ");
            Console.WriteLine("1:Position");
            int Options = Convert.ToInt32(Console.ReadLine());
            switch(Options)
            {
                case 1:
                    SnakeLadder snakeLadder = new SnakeLadder();
                    //snakeLadder.Game();
                    snakeLadder.Ladder();
                    break;
            }
        }
    }
}
