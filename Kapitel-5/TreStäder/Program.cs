using System;

namespace TreStäder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tre svenska städer!");

            /* 
            Skapa ett program som innehåller en array som ska innehålla namnen på tre svenska städer. 
            Skriv in två av namnen i programmets kod men låt användaren få skriva in namnet på den tredje staden. 
            Skriv avslutningsvis ut alla stadsnamnen på samma rad.
            */

            // Skapa en tom array som ska innehålla namnen på tre svenska städer
            string[] städer = new string[3];

            // Skriv in två av namnen i programmets kod
            städer[0] = "Stockholm";
            städer[1] = "Göteborg";

            // Låt användaren få skriva in namnet på den tredje staden
            Console.WriteLine("Städer: " + städer[0] + ", " + städer[1]);
            Console.Write("Skriv in ett namn på en svensk stad: ");
            string stad = Console.ReadLine();
            städer[2] = stad;

            // Skriv avslutningsvis ut alla stadsnamnen på samma rad
            for (int i = 0; i < städer.Length; i++)
            {
                Console.Write(städer[i] + " ");
            }
        }
    }
}
