using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Lyckohjulet!");
            Random generator = new Random();

            // Loopen
            int varv = 1;
            while (true)
            {
                // När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
                Console.Write("Välj ett tal från 1 till 10: ");
                string gissningString = Console.ReadLine();
                int gissning = int.Parse(gissningString);

                // Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
                int slumptal = generator.Next(1, 11);
                Console.WriteLine($"Lyckohjulet hamnade på {slumptal}");

                // Berätta också för användaren om hen vann eller förlorade
                if (gissning == slumptal)
                {
                    Console.WriteLine("Du vann!");
                }
                else
                {
                    Console.WriteLine("Du förlorade!");
                }

                // Räkna upp varv
                varv++;

                // Avsluta när loopen gått 3 varv
                if (varv == 4)
                {
                    break;
                }
            }
        }
    }
}
