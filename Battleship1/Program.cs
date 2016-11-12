using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {

        static void Main(string[] args)

        {
            
            while (true)
            {
                printGrid(Grid);
                Console.WriteLine("Type 'quit' to exit.");
                Console.WriteLine("Enter your guess:");
                string cons = Console.ReadLine();
                char column = cons[0];
                int num;
                bool result = Int32.TryParse(cons, out num);
                char.ToUpper(column);
                string validChars = "ABCDEFGHIJ";

                if (Console.ReadLine() == "QUIT")
                {
                    return;
                }
                else if (!validChars.Contains(column) || (num > 11))
                {
                    Console.WriteLine("Please enter the correct format e.g. 'B5'");
                }

                
            }
        }

        public static void printGrid(Char[,] Grid)
        {

            Console.WriteLine("   | A | B | C | D | E | F | G | H | I | J |");
            Console.WriteLine("---#---#---#---#---#---#---#---#---#---#---#");

            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write("{0} ", i + 1);
                }
                else
                    Console.Write(" {0} ", i + 1);

                for (int j = 0; j < 10; j++)
                {
                    ShipColors(Grid[i, j]);
                }

                Console.Write("|\r\n");
                Console.WriteLine("---#---#---#---#---#---#---#---#---#---#---#");
            }
        }

        private static readonly char[,] Grid = new char[,]
        {
            {'.', '.', '.', '.', 'S', 'S', 'S', '.', '.', '.'},
            {'P', 'P', '.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', 'P'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', 'P'},
            {'.', '.', 'A', 'A', 'A', 'A', 'A', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', 'P', 'P'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
        };

        public static void ShipColors(char useThis)
        {
            //P = patrol baot
            //S = Submarine
            //B = Battleship
            //A = Aircraft carrier

            switch (useThis)
            {
                case '.':
                    Console.Write("|   ");
                    break;
                case 'A':
                    Console.Write("|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" A ");
                    break;
                case 'B':
                    Console.Write("|");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" B ");
                    break;
                case 'P':
                    Console.Write("|");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write(" P ");
                    break;
                case 'S':
                    Console.Write("|");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" S ");
                    break;
                case 'H':
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" X ");
                    break;
                case 'M':
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" X ");
                    break;

            }

            Console.ResetColor();
        }


    }
}
