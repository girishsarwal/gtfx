using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class LookupManager<T, V>
    {
        public event EventHandler<V> ItemAdded;
        public Boolean Initialized { get; set; }
        private Dictionary<T, V> Items
        {
            get;
            set;
        }
        public virtual void Initialize()
        {
            Initialized = true;
        }
        public virtual void Shutdown()
        {
            Initialized = false;
        }
        public virtual void Reset()
        {
            Items.Clear();
        }
        public virtual void Update()
        {
        }


        public void Remove(T key)
        {
            Items.Remove(key);
        }

        public V this[T key]
        {
            get
            {
                return Items[key];
            }
            set
            {
                Items.Add(key, value);
                OnItemAdded(value);
            }
        }


        public LookupManager()
        {
            Initialized = false;
            Items = new Dictionary<T, V>();
        }

        protected void OnItemAdded(V item)
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, item);
            }
        }
    }
}
