using System;

namespace ForLoopen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop Motherfuker loop!");

            // While-loopen: när du inte vet hur många ggr
            // For-loopen: när du vet hur många ggr du skall loopa, tex 10 ggr
            /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Varv nr " + i);
            } */

            // Loop 20 ggr
            /* for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Varv");
            } */

            // Loop 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
            /* for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
            } */

            // Skriv ut årtalen 1999-2009
            /* for (int i = 1999; i < 2009; i++)
            {
                Console.WriteLine(i);
            } */

            // Skriv ut årtalen 2022, 2021, 2020, 2019, 2018
            /* for (int i = 2022; i >= 2018; i--)
            {
                Console.WriteLine(i);
            } */

            // Skriv ut var femte år från 2000-2020
            /* for (int i = 2000; i <= 2020; i += 5)
            {
                Console.WriteLine(i);
            } */

            // Skapa ett program som slumpar fram fem tal 1-6, ett per rad.
            Random generator = new Random();
            /* for (int i = 0; i < 5; i++)
            {
                int slumptal = generator.Next(1, 7);
                Console.WriteLine(slumptal);
            } */

            // Skapa ett program som skriver ut en fyrkant med *
            // ****
            // ****
            // ****
            // ****
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("****");
            }
        }
    }
}
