using System;

namespace DotStarThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a whole number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            int j = 0;

            while (j < num)
            {
                j++;
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");

                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (i % 2 != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
