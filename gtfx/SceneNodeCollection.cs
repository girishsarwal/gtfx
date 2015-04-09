using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneNodeCollection
        : Collection<ISceneNode>
        , ISceneNode
    {
        public SceneNodeCollection()
        {
            
        }
        protected override void InsertItem(int index, ISceneNode item)
        {
            /** Add this item to the entity manager **/
            if(item.GameObject != null)
                SceneManager.Instance[item.GameObject.Name] = item;
            OnChanged();
            base.InsertItem(index, item);

        }
        protected override void RemoveItem(int index)
        {
            /** remove this itme from the entity manager **/
            base.RemoveItem(index);
        }

        public event EventHandler Changed;

        public GameObject GameObject
        {
            get
            {
                /** return the gameobject on the first item **/
                return null;
            }
            set
            {
                value = null;
            }
        }

        public void Update(UpdateEventArgs args)
        {
            foreach (ISceneNode item in Items)
            {
                item.Update(args);   
            }
        }

        protected void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
    }
}
