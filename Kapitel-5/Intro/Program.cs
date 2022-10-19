using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrayer!");

            // Skapa en samling med 5 namn på länder
            // Array, List, Dictionary, Map..
            // array [] (klammer på sv, brackets på en)

            // 1. Första sättet att skapa en array
            // Skapa en array som innehåller 5 länder
            string[] länder = {"Ghana", "Rwanda", "Egypten", "Etiopien", "Nigeria"};

            // Skapa en array som innehåller 3 namn
            string[] namnen = {"Leif", "Simon", "Theo"};

            // Skapa en array som innehåller 3 årtal
            int[] årtalen = {2022, 2021, 2020};
            string[] årtalen2 = {
                                 "2022", // 0
                                 "2021", // 1
                                 "2020"  // 2
                                };

            // Använda arrayen som vi har skapat
            Console.WriteLine("Ett land i Afrika: " + länder[0]);

            // Skriv ut 3:e namnet i arrayen namnen
            Console.WriteLine("Ett namn " + namnen[2]);

            // Skriv ut första och sista årtaler ur arrayen "årtalen"
            Console.WriteLine(årtalen[0] + " " + årtalen[2]);

            // 2. Andra sättet - TOM array, sen fyller vi den
            int[] slumptalen = new int[6];  // 6 tomma platser, 0-5

            // Skapa en tom array som heter "kompisar" för alla i klassen
            // För att spara namnen på alla kompisar
            string[] kompisar = new string[11];

            // Fyll arrayen "kompisar" med namn
            kompisar[0] = "Simon";
            kompisar[1] = "Leif";
            kompisar[2] = "Ermias";
            kompisar[3] = "Tomas";
            kompisar[4] = "Theo";
            kompisar[5] = "Tora";
            kompisar[6] = "Eris";
            kompisar[7] = "Edyta";
            kompisar[8] = "Felicia";
            kompisar[9] = "Angelina";
            kompisar[10] = "Abdulahi";

            // Vilka verktyg har man till arrayer
            // Hur långa är en array?
            Console.WriteLine("Arrayen kompisar har " + kompisar.Length + " platser");

            // Skriv ut hela arrayen kompisar, ett namn per rad
            Console.WriteLine(kompisar);    // Det här funkar inte!

            // Loopa igenom arrayen
            for (int i = 0; i < kompisar.Length; i++)
            {
                Console.WriteLine(kompisar[i]);
            }
        }
    }
}
