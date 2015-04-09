using SlimDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class TransformComponent
        : GameObjectComponent
    {
        public SlimDX.Matrix World { get; set; }
        public SlimDX.Matrix Local { get; set; }
        
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }

        public TransformComponent(GameObject owner)
            : this("Transform", owner)
        {
            
        }
        public TransformComponent(string name, GameObject owner)
            : base(owner)
        {
            Name = name;
            Local = Matrix.Identity;
            World = Matrix.Identity;

        }
    }
}
