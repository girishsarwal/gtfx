using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class Scene
    {
        public event EventHandler SceneChanged;
        public ISceneNode Root
        {
            get;
            private set;
        }
        protected void OnSceneChanged()
        {
            if (SceneChanged != null)
            {
                SceneChanged(this, EventArgs.Empty);
            }
        }
        public void RaiseSceneChanged()
        {
            OnSceneChanged();
        }
        public void Update(UpdateEventArgs args)
        {

        }
        public Scene()
        {
            Root = new SceneNodeCollection();
        }
    }
}
