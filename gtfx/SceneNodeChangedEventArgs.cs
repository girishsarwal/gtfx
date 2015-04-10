using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gtfx
{
    public class SceneNodeChangedEventArgs
    {
        
        public SceneNode Node { get; private set; }
        public SceneNode Item { get; private set; }
        public SceneNodeChangedEvent Event { get; private set; }
        public SceneNodeChangedEventArgs(SceneNode node, SceneNode item, SceneNodeChangedEvent e)
        {
            Node = node;
            Item = item;
            Event = e;
        }
    }
}
