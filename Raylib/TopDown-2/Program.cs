﻿using System;
using Raylib_cs;

namespace TopDown_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Slå på ljudet
            Raylib.InitAudioDevice();
            Raylib.SetMasterVolume(0.5f);

            // Ladda in ljudet
            Sound explosion = Raylib.LoadSound("./resurser/explosion.mp3");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Ladda in bilden
            Texture2D texturLandare = Raylib.LoadTexture(@"./resurser/lander.png");
            // Hitbox
            Rectangle landare = new Rectangle(200, 100, 128, 128);

            // Ladda bilden på ufot
            Texture2D texturUfo = Raylib.LoadTexture(@"./resurser/ufo.png");
            // Hitbox
            Rectangle ufo = new Rectangle(300, 300, 32, 32);
            
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.BEIGE);

                Raylib.DrawTexture(texturLandare, (int)landare.x, (int)landare.y, Color.WHITE);
                Raylib.DrawTexture(texturUfo, (int)ufo.x, (int)ufo.y, Color.WHITE);

                // Lyssna på piltangenterna
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    landare.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    landare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    landare.y -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    landare.y += 5;
                }

                // Lyssna på musen
                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    ufo.x = Raylib.GetMouseX();
                    ufo.y = Raylib.GetMouseY();
                }

                // Kolliderar ufon med landaren?
                if (Raylib.CheckCollisionRecs(ufo, landare))
                {
                    Raylib.DrawRectangle(0, 0, 800, 600, Color.RED);
                    Raylib.DrawText("Träff", 500, 50, 24, Color.GOLD);

                    // Starta ljudet en gång!
                    if (!Raylib.IsSoundPlaying(explosion))
                    {
                        Raylib.PlaySound(explosion);
                    }
                }

                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }
        }
    }
}
