using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MouvementRaylib
{
    internal class GameObject
    {
        public List<Component> components;

        public Vector2 Position;

        public virtual void Render()
        {

        }
    }
}
