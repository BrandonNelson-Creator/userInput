using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            
            int sides = 10;
            

            while (gameOver == false)
            {
                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
                Console.Clear();
                char input = readKeyInput.KeyChar;

                //Console.WriteLine("User Input = " + input);

                if (input == 'w')
                {
                    sides--;
                    Console.SetCursorPosition(10, sides);
                    Console.WriteLine("Move up");
                   
                }

                if (input == 'a')
                {
                    sides--;
                    Console.SetCursorPosition(sides, 10);
                    Console.WriteLine("Move left");
                }

                if (input == 's')
                {
                    sides++;
                    Console.SetCursorPosition(10, sides);
                    Console.WriteLine("Move Down");
                }

                if (input == 'd')
                {
                    sides++;
                    Console.SetCursorPosition(sides, 10);
                    Console.WriteLine("Move Right");
                }

                

                
            }
        }
    }
}
