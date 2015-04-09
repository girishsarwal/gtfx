using SlimDX;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class MeshComponent
        : GameObjectComponent
    {
        public VertexBuffer VertexBuffer
        {
            get;
            protected set;
        }
        public IndexBuffer IndexBuffer
        {
            get;
            protected set;
        }

        public MaterialCollection Materials
        {
            get;
            protected set;
        }
        
        public MeshComponent(GameObject owner)
            : this("Mesh", owner)
        {
            
        }
        public MeshComponent(string name, GameObject owner)
            : base(owner)
        {
            this.Name = name;
            this.Enabled = true;
        }
    }
}
