using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneNode
        : ISceneNode
    {
        internal SceneNode(string name)
            : this()
        {
            Name = name;
            CanBeNamed = false;
        }
        public SceneNode()
        {
            CanBeNamed = true;
        }

        public event EventHandler Changed;
        public GameObject GameObject { get; set; }
        public void Update(UpdateEventArgs args)
        {
        
        }
        
        protected void OnChanged()          /** scene manager.notify change **/
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (CanBeNamed)
                    name = value;
            }
        }

        public bool CanBeNamed
        {
            get;
            internal set;
        }
    }
}
