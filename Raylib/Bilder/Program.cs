using System;
using Raylib_cs;    // dotnet add package Raylib-cs

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello bilder!");

            // Starta Raylibs grafikmotor
            Raylib.InitWindow(800, 600, "Mitt första Raylib-fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(30);

            // Ladda in bilderna som texturer
            Texture2D vinterTextur = Raylib.LoadTexture("./resurser/winter.png");
            Texture2D solTextur = Raylib.LoadTexture("./resurser/sun.png");
            Texture2D granTextur = Raylib.LoadTexture("./resurser/pine.png");

            // Ladda in bild på tomten
            Texture2D tomtenTextur = Raylib.LoadTexture("./resurser/sleigh.png");

            // EN ruta som vi skall förflytta
            Rectangle ruta = new Rectangle(0, 0, 50, 50);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut bilderna
                Raylib.DrawTexture(vinterTextur, 100, 300, Color.WHITE);
                Raylib.DrawTexture(solTextur, 600, 100, Color.WHITE);
                Raylib.DrawTexture(granTextur, 300, 300, Color.WHITE);
                Raylib.DrawTexture(granTextur, 350, 350, Color.WHITE);
                Raylib.DrawTexture(granTextur, 450, 300, Color.WHITE);
                Raylib.DrawTexture(granTextur, 500, 300, Color.WHITE);
                Raylib.DrawTexture(granTextur, 550, 350, Color.WHITE);
                Raylib.DrawTexture(granTextur, 650, 300, Color.WHITE);

                Raylib.DrawTexture(tomtenTextur, (int)ruta.x, (int)ruta.y, Color.WHITE);

                // Rita ut rutan
                //Raylib.DrawRectangleRec(ruta, Color.BLACK);

                // Om användaren trycker D så flytta åt höger
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    ruta.x += 5;   
                }
                // Om användaren trycker A så flytta åt vänster
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    ruta.x -= 5;   
                }
                // Om användaren trycker W så flytta åt höger
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    ruta.y -= 5;   
                }
                // Om användaren trycker S så flytta åt vänster
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    ruta.y += 5;   
                }

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
