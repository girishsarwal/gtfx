using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class Cube
        : GameObject
    {
        public Cube()
        {
            Components.Add(new MeshComponent(this));
            Components.Add(new ColliderComponent(this));

        }
    }
}
