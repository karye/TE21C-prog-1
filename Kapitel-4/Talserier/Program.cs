using System;

namespace Talserier
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program som skriver ut talen 10, 11, 12 o.s.v. upp till och med 30. Därefter ska programmet skriva ut talen 200, 199, 198 o.s.v. ner till och med 180. Slutligen ska programmet skriva ut talen 1000, 1050, 1100, 1150 o.s.v. upp till och med 1400.
             */
            Console.WriteLine("Talserier!");

            // skriver ut talen 10, 11, 12 o.s.v. upp till och med 30
            for (int i = 10; i <= 30; i++)
            {
                Console.WriteLine(i);
            }

            // skriva ut talen 200, 199, 198 o.s.v. ner till och med 180
            for (int i = 200; i >= 180; i--)
            {
                Console.WriteLine(i);
            }

            // Skriva ut talen 1000, 1050, 1100, 1150 o.s.v. upp till och med 1400.
            for (int i = 1000; i <= 1400; i += 50)
            {
                Console.WriteLine(i);
            }
        }
    }
}
