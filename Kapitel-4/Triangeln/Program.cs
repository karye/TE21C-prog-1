using System;

namespace Triangeln
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa ett program som ritar ut en rätvinklig triangel där användaren får bestämma triangelns sidlängd. Om användaren till exempel anger sidlängden 5 så ska följande triangel ritas ut:
            *
            **
            ***
            ****
            *****
            */
            /* Console.WriteLine("Triangeln!");

            // *
            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // **
            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // ***
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // ****
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // *****
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); */

            // Först en loop 1-5
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
