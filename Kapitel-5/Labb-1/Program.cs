using System;

namespace Labb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceasarkryptering!");

            //  Läs in ett meddelande
            Console.Write("Ange ett meddelande: ");
            string meddelande = Console.ReadLine();

            // Läs in en nyckel
            Console.Write("Ange en nyckel (1-10): ");
            int nyckel = int.Parse(Console.ReadLine());
            
            // Plocka ut varje tecken, en-för-en
            // Loopa igenom alla tecken i meddelandet
            string meddelandeCeasar = "";
            for (int i = 0; i < meddelande.Length; i++)
            {
                // Skriv ut tecknet
                char tecken = meddelande[i];
                //Console.WriteLine(tecken);

                // Skriv ut ASCII-värdet för tecknet
                int teckenASCII = (int)tecken;
                //Console.WriteLine(teckenASCII);

                // Plusa på en nyckel
                teckenASCII += nyckel;
                //Console.WriteLine(teckenASCII);

                // Plocka ut bokstaven
                char teckenCeasar = (char)teckenASCII;
                //Console.WriteLine(teckenCeasar);

                // Skriv ut tecknet och dess krypterade motsvarighet
                //Console.WriteLine($"{tecken} blir {teckenCeasar}");

                // Samla ihop de krypterade tecknen
                meddelandeCeasar += teckenCeasar.ToString();
            }

            // Skriv ut det krypterade meddelandet
            Console.WriteLine($"Det krypterade meddelandet blir: {meddelandeCeasar}");
        }
    }
}
