using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gtfx
{
    public class SceneNodeCollectionChangedEventArgs
    {
        public SceneNode Item { get; set; }
        public SceneNodeChangedEvent Event { get; set; }
        
        public SceneNodeCollectionChangedEventArgs(SceneNode item, SceneNodeChangedEvent e)
        {
            Item = item;
            Event = e;
        }
    }
}
