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
        internal SceneNodeCollection(string name)
            : this()
        {
            Name = name;
            CanBeNamed = false;
        }
        public SceneNodeCollection()
        {
            CanBeNamed = true;
        }
        protected override void InsertItem(int index, ISceneNode item)
        {
            /** Add this item to the entity manager **/
            SceneManager.Instance[item.Name] = item;
            base.InsertItem(index, item);

        }
        protected override void RemoveItem(int index)
        {
            /** remove this itme from the entity manager **/
            base.RemoveItem(index);
        }

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
