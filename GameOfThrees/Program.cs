using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                uint input = uint.Parse(Console.ReadLine().ToString());

                var gameOfThrees = new GameOfThrees(input);
                gameOfThrees.Run();
            }
        }

        public class GameOfThrees
        {
            private uint currentValue;

            private GameOfThrees() { }

            public GameOfThrees(uint input)
            {
                currentValue = input;
            }

            public void Run()
            {
                while (currentValue > 1)
                {
                    uint difference = currentValue % 3;

                    if (difference == 0)
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + 0);
                    }
                    else if (difference == 1)
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + (difference - 2));
                        currentValue -= 1;
                    }
                    else
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + (difference - 1));
                        currentValue += 1;
                    }
                    currentValue /= 3;
                }
                Console.WriteLine(currentValue.ToString());
            }
        }
    }
}
