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

            public GameOfThrees(uint input)
            {
                currentValue = input;
            }

            public void Run()
            {
                while (currentValue > 1)
                {
                    uint remainder = currentValue % 3;

                    if (remainder == 0)
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + remainder.ToString());
                    }
                    else if (remainder == 1)
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + (Convert.ToInt32(remainder) - 2));
                        currentValue -= 1;
                    }
                    else
                    {
                        Console.WriteLine(currentValue.ToString() + ' ' + (remainder - 1));
                        currentValue += 1;
                    }
                    currentValue /= 3;
                }
                Console.WriteLine(currentValue.ToString());
            }
        }
    }
}
