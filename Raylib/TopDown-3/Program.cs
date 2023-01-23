using System;
using Raylib_cs;

namespace TopDown_3
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Variabler
            int poäng = 0;

            Raylib.InitWindow(512, 480, "Raylib");
            Raylib.SetTargetFPS(60);
            
            // Ladda in en bild
            Texture2D texturLander = Raylib.LoadTexture(@"./resurser/lander.png");
            // Skapa en hitbox
            Rectangle hitboxLander = new Rectangle(0, 0, texturLander.width, texturLander.height);

            // Skapa en poängrektangel
            Rectangle poängRektangel = new Rectangle(400, 300, 50, 50);
            
            // Animationsloop
            // Här ritas grafiken ut i 60 fps
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut poäng
                Raylib.DrawText($"Poäng: {poäng}", 0, 0, 28, Color.WHITE);

                // Rita ut poängrektangeln
                Raylib.DrawRectangleRec(poängRektangel, Color.BROWN);

                // Rita ut lander
                Raylib.DrawTexture(texturLander, (int)hitboxLander.x, (int)hitboxLander.y, Color.WHITE);

                // Styra lander med piltangenterna
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    hitboxLander.x += 1;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    hitboxLander.x -= 1;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    hitboxLander.y += 1;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    hitboxLander.y -= 1;
                }

                // Öka poäng när hitbox träffar den andra rektangeln
                if (Raylib.CheckCollisionRecs(hitboxLander, poängRektangel))
                {
                    poäng++;

                    // Slumpa fram en ny position
                    poängRektangel.x = Raylib.GetRandomValue(0, 512);
                    poängRektangel.y = Raylib.GetRandomValue(0, 480);
                }
                
                Raylib.EndDrawing();
            }
        }
    }
}
