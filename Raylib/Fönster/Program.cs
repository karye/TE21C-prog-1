using System;
using Raylib_cs;

namespace Fönster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raylib fönster!");

            // Starta Raylibs grafikmotor
            Raylib.InitWindow(800, 600, "Mitt första Rayllib-fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(30);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Vår egen kod!
                Raylib.ClearBackground(Color.BEIGE);

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
