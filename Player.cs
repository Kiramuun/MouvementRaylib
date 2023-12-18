using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace MouvementRaylib
{
    internal class Player : GameObject
    {
        Mouvement _mouv = new Mouvement();
        Texture2D _texturePerso = LoadTexture("Blue_Head_Walking-Sheet.png");
        public override void Render()
        {
            Vector2 position = new Vector2(_mouv.xPos, _mouv.yPos);
            Rectangle frameRec = new Rectangle(_mouv.frameX * _texturePerso.Width / 4, _mouv.frameY * _texturePerso.Height / 4, _texturePerso.Width / 4, _texturePerso.Height / 4);
            _mouv.Update();
            DrawTextureRec(_texturePerso, frameRec, position, Color.WHITE);
        }
    }
}
