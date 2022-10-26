using System;

namespace Filmer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Array för 10 filmer. Användaren matar in filmer array. */
            Console.WriteLine("Tio i topp filmer!");

            // Array för 10 filmer
            string[] filmer = new string[10];

            // Användaren matar in filmer i arrayen
            for (int i = 0; i < filmer.Length; i++)
            {
                // Fråga användaren efter en film
                Console.Write("Ange namn på film: ");
                filmer[i] = Console.ReadLine();
            }

        }
    }
}
