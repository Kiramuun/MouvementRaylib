using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace MouvementRaylib
{
    internal class Mouvement : Component
    {
        public float xPos = 155,
                   yPos = 105,
                   frameX = 0,
                   frameY = 1;
        int speed = 100;

        float animSpeed = 300;


        public void Update()
        {
            if (IsKeyDown(KeyboardKey.KEY_RIGHT)) { xPos += speed*GetFrameTime();}
            if (IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                frameY = 3;
                frameX++;
                //frameX = MathF.Round(frameX+animSpeed*GetFrameTime());
                if (frameX >= 4) { frameX = 0; }
            }
            if (IsKeyDown(KeyboardKey.KEY_LEFT)) { xPos -= speed * GetFrameTime();}
            if (IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                frameY = 2;
                frameX++;
                if (frameX >= 4) { frameX = 0; }
            }
            if (IsKeyDown(KeyboardKey.KEY_DOWN)) { yPos += speed * GetFrameTime();}
            if (IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                frameY = 1;
                frameX++;
                if (frameX >= 4) { frameX = 0; }
            }
            if (IsKeyDown(KeyboardKey.KEY_UP)) { yPos -= speed * GetFrameTime();}
            if (IsKeyDown(KeyboardKey.KEY_UP))
            {
                frameY = 0;
                frameX++;
                if (frameX >= 4) { frameX = 0; }
            }
        }

    }
}
