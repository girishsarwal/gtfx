using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class ColliderComponent
        : GameObjectComponent
    {
        public ColliderComponent(GameObject owner)
            : this("Collider", owner)
        {

        }
        public ColliderComponent(string name, GameObject owner)
            : base(owner)
        {
            this.Name = name;
            this.Enabled = true;
        }

        public void Update(UpdateEventArgs e)
        {
         
        }
    }
}
