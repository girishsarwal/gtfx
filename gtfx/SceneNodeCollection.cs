using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneNodeCollection
        : Collection<SceneNode>
    {
        public SceneNodeCollection(SceneNode parent)
        {
            Parent = parent;
        }
        //public event EventHandler<SceneNodeCollectionChangedEventArgs> Changed;
        public SceneNode Parent
        {
            get;
            set;
        }
        protected override void InsertItem(int index, SceneNode item)
        {
            /** Add this item to the entity manager **/
            item.Parent = this.Parent;
            SceneManager.Instance[item.Name] = item;
            OnChanged(new SceneNodeCollectionChangedEventArgs(item, SceneNodeChangedEvent.NodeAdded));
            base.InsertItem(index, item);
        }

        protected void OnChanged(SceneNodeCollectionChangedEventArgs args)
        {
            Parent.OnChanged(new SceneNodeChangedEventArgs(Parent, args.Item, SceneNodeChangedEvent.NodeAdded));
        }
        protected override void RemoveItem(int index)
        {
            /** remove this itme from the entity manager **/
            base.RemoveItem(index);
        }

        public void Update(UpdateEventArgs args)
        {
            foreach (SceneNode item in Items)
            {
                item.Update(args);   
            }
        }
    }
}
