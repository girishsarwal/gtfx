using SlimDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class PhysicsComponent
        : GameObjectComponent
    {
        public float Mass { get; set; }
        public Vector3 Force { get; set; }
        public Vector3 Acceleration { get; set; }
        
        public Boolean AffectedByForce { get; set; }
        public Boolean AffectedByGravity { get; set; }
        public void ApplyForce(Vector3 force)
        {
        }
        public void ClearForce()
        {
        }
        public PhysicsComponent(GameObject owner)
            : this("Physics", owner)
        {
            
        }
        public PhysicsComponent(string name, GameObject owner)
            : base (owner)
        {
            this.Name = name;
            this.Enabled = true;
            this.Mass = 1.0f;         //cant be zero
        }

    }
}
