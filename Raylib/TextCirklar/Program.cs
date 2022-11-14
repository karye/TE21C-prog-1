using System;
using System.Numerics;
using Raylib_cs;

namespace TextCirklar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RayLib text & cirklar!");

            // Starta Raylibs grafikmotor
            Raylib.InitWindow(800, 600, "Mitt första Rayllib-fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(30);

            // Skapa en egen färg 
            Color Goldred = new Color(218, 165, 32, 255);
            Color LightSlateGrey = new Color(119, 136, 153, 255);

            // Ladda in fonten
            Font lora = Raylib.LoadFontEx("Lora-VariableFont_wght.ttf", 120, null, -1);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Vår egen kod!
                Raylib.ClearBackground(Color.SKYBLUE);

                // Rita en sol
                Raylib.DrawCircle(200, 200, 50, Goldred);

                // Rita moln
                Raylib.DrawCircle(150, 100, 50, LightSlateGrey);
                Raylib.DrawCircle(250, 70, 100, LightSlateGrey);
                Raylib.DrawCircle(400, 50, 150, LightSlateGrey);
                Raylib.DrawCircle(500, 80, 100, LightSlateGrey);
                Raylib.DrawCircle(600, 100, 50, LightSlateGrey);

                // Skriv ut text
                Raylib.DrawText("En vacker sommardag", 100, 400, 30, Color.DARKPURPLE);
                Raylib.DrawText("SOL", 500, 400, 80, Color.RED);
                Raylib.DrawTextEx(lora, "Lora", new Vector2(500, 200), 120, 1, Color.RED);

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
