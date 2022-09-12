using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Does i move? ");
            string svar = Console.ReadLine();
            if (svar == "no")
            {
                Console.WriteLine("Should it? ");
                if (svar == "no")
                {
                    Console.WriteLine("No problem!");
                }
                else
                {
                    Console.WriteLine("Use WD-40");
                }
            }
            else
            {
                Console.WriteLine("Should it? ");
                if (svar == "yes")
                {
                    Console.WriteLine("No problem!");
                }
                else
                {
                    Console.WriteLine("Use Duct tape");
                }
            }
        }
    }
}
