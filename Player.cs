using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MouvementRaylib
{
    internal class Player : GameObject
    {
        Vector2 position;
        Vector2 size;
        Mouvement _mouv = new Mouvement();
        public override void Render()
        {
            _mouv.Update();
            position = new Vector2(_mouv.xPos, _mouv.yPos);
            size = new Vector2(40, 40);
            Raylib.DrawRectangleV(position, size, Color.RED);
        }
    }
}
