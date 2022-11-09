using System;
using Raylib_cs;

namespace Fyrkanter
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

                // Rita ut en fyrkanter
                Raylib.DrawRectangle(100, 100, 200, 100, Color.PINK);
                Raylib.DrawRectangle(400, 100, 200, 100, Color.BROWN);
                Raylib.DrawRectangle(200, 300, 200, 100, Color.DARKGRAY);

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
