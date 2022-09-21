/* 
Skriv ett program som ställer en fråga till användaren, t.ex. ”Vilket är världens folkrikaste land?”. Så länge som användaren svarar fel ska hon få en ny chans att svara på frågan.
 */

using System;

namespace Uppgift4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            while (true)
            {
                Console.WriteLine("Vilket är världens folkrikaste land?");
                string svar = Console.ReadLine();
                
                // Om svaret är "Kina" avbryt loopen
                if (svar == "Kina")
                {
                    Console.WriteLine("Rätt svar");
                    break;
                }
            }
        }
    }
}
