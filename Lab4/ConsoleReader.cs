using System;

namespace Lab4
{
    public class ConsoleReader
    {
        public int ReadAnswer(string mainWord, int maxKey)
        {
            Console.Write($"Please, choose some {mainWord} (or enter 0 to exit): ");

            int key = 0;

            while (!Int32.TryParse(Console.ReadLine(), out key) || key > maxKey || key < 0)
            {
                Console.Write($"Please, choose some {mainWord} (or enter 0 to exit): ");
            }

            return key;
        }

    }
}
