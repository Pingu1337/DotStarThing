using System;

namespace DotStarThing
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Type a Whole Number:");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            int j = 0;

                while (j < num)
                {
                    j++;
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
