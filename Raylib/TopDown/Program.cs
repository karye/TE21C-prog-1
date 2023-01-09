using System;
using Raylib_cs;

namespace TopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raylib!");

            // Starta Raylibs grafikmotor
            Raylib.InitWindow(800, 600, "Mitt första Raylib-fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(30);

            Texture2D texturVal = Raylib.LoadTexture(@"./resurser/whale.png");

            // Valens position
            int x = 200;
            int y = 100;

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                //Raylib.DrawRectangle(100, 100, 50, 100, Color.BLUE);
                Raylib.DrawTexture(texturVal, x, y, Color.WHITE);

                // Lyssna på piltangenterna
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    y += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    y -= 5;
                }

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
