using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class GameObjectComponent
        : IComponent
    {
        public GameObject Owner
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public bool Initialized
        {
            get;
            set;
        }

        public virtual void Initialize()
        {
            Initialized = true;
        }

        public virtual void Update(UpdateEventArgs e)
        {
            if (!Initialized)
                Initialize();
        }
        public GameObjectComponent(GameObject owner)
        {
            Owner = owner;
        }
    }
}
