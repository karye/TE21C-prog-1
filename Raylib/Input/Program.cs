using System;
using Raylib_cs;    // dotnet add package Raylib-cs

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en slumpgenerator
            Random generator = new Random();

            // Start hastigheter
            int vx = generator.Next(-5, 5);
            int vy = generator.Next(-5, 5);

            Console.WriteLine("Jaga pucken!");

            // Starta Raylibs grafikmotor
            Raylib.InitWindow(800, 600, "Jaga pucken");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(30);

            /*** Skapa objekt ***/
            Rectangle fiende = new Rectangle(100, 100, 100, 100);
            Rectangle spelare = new Rectangle(0, 0, 50, 50);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.LIGHTGRAY);

                /*** Rita ut ***/
                Raylib.DrawRectangleRec(fiende, Color.PINK);
                Raylib.DrawRectangleRec(spelare, Color.BLACK);

                /*** Uppdatering ***/
                // Flytta på spelaren med piltangenter
                // Om användaren trycker D så flytta åt höger
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    spelare.x += 5;   
                }
                // Om användaren trycker A så flytta åt vänster
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    spelare.x -= 5;   
                }
                // Om användaren trycker W så flytta åt höger
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    spelare.y -= 5;   
                }
                // Om användaren trycker S så flytta åt vänster
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    spelare.y += 5;   
                }

                // Fiende förflyttar sig 5px åt höger
                fiende.x += vx;

                // Fiende förflyttar sig 3px nedåt
                fiende.y += vy;

                // När fiende når högerkanten börjar den om till vänster
                if (fiende.x + 100 > 800)
                {
                    vx = -generator.Next(0, 5);
                }
                // När fiende när nederkanten börjar den om upptill
                if (fiende.y + 100 > 600)
                {
                    vy = -generator.Next(0, 5);
                }
                // När fiende når vänsterkanten börjar den om till höger
                if (fiende.x < 0)
                {
                    vx = generator.Next(0, 5);
                }
                // När fiende när nederkanten börjar den om upptill
                if (fiende.y < 0)
                {
                    vy = generator.Next(0, 5);
                }

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
