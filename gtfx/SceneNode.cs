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
        public SceneNode()
        {
            
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
    }
}
