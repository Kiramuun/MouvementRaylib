using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MouvementRaylib
{
    internal class Mouvement : Component
    {
        public int xPos = 155,
                   yPos = 105;
        
        

        public void Update()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) { xPos += 50; }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) { xPos -= 50; }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN)) { yPos += 50; }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP)) { yPos -= 50; }
        }
        
    }
}
