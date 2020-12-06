// Adam Burford
// COP4504
// 99 Bottles

using System;

namespace _99bottles
{
    class Bottles
    {
        static void Main(string[] args)
        {
            for (int i = 99; i >= 3; i--)
            {
                Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer.", i);
                Console.WriteLine("Take one down and pass it around, {0} bottles of beer on the wall.\n", i - 1);
            }

            Console.WriteLine("2 bottles of beer on the wall, 2 bottles of beer.");
            Console.WriteLine("Take one down and pass it around, 1 bottle of beer on the wall.\n");

            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
            Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.\n");

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.\n");

        }
    }
}
