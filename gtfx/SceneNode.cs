using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneNode
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
            children = new SceneNodeCollection(this);
        }

        public event EventHandler<SceneNodeChangedEventArgs> Changed;

        [Category("Game Object")]
        public GameObject GameObject { get; set; }
        public void Update(UpdateEventArgs args)
        {
            foreach (SceneNode item in Children)
            {
                item.Update(args);
            }
        }
        
        private string name;
        
        [Category("General")]
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
        [Browsable(false)]
        public bool CanBeNamed
        {
            get;
            internal set;
        }

        [Browsable(false)]
        public SceneNode Parent
        {
            get;
            internal set;
        }

        private SceneNodeCollection children;
        [Browsable(false)]
        public SceneNodeCollection Children
        {
            get
            {
                return children;
            }
            set
            {
                children = value;
                OnChanged(new SceneNodeChangedEventArgs(null, null, SceneNodeChangedEvent.NodeAdded));
            }
        }
        internal void OnChanged(SceneNodeChangedEventArgs args)          
        {
            if (Changed != null)
                Changed(this, args);
        }
    }
}
