using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa en array med dikt av Karin Boye. 
            Skriv ut nyrad efter varje punkt. */
            Console.WriteLine("I rörelse!");

            // Skapa en array med dikten "I rörelse!" av Karin Boye.
            string[] diktRader = {
                                    "Den mätta dagen, den är aldrig störst.",
                                    "Den bästa dagen är en dag av törst.",
                                    "Nog finns det mål och mening i vår färd -",
                                    "men det är vägen, som är mödan värd.",
                                    "Det bästa målet är en nattlång rast,",
                                    "där elden tänds och brödet bryts i hast.",
                                    "På ställen, där man sover blott en gång,",
                                    "blir sömnen trygg och drömmen full av sång.",
                                    "Bryt upp, bryt upp! Den nya dagen gryr.",
                                    "Oändligt är vårt stora äventyr.",
                                };

            // Skriv ut alla rader från arrayen
            // Skriv ut nyrad om raden slutar med punkt (.EndsWith())
            for (int i = 0; i < diktRader.Length; i++)
            {

                // Om raden slutar med ".", lägg till en extra tomrad
                if (diktRader[i].EndsWith("."))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(diktRader[i]);
                }
            }

        }
    }
}
