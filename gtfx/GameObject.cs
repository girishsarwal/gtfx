using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GameObject
        : IStateMachine
    {
        [Category("State Machine")]
        public IState CurrentState
        {
            get;
            set;
        }
        [Category("State Machine")]
        public IState PreviousState
        {
            get;
            set;
        }
        [Category("Components")]
        public ComponentCollection Components
        {
            get;
            set;
        }

        public GameObject()
        {
            Components = new ComponentCollection();
            Components.Add(new TransformComponent("Transform", this));
            Id = GetNextId();
        }
        [Browsable(false)]
        public Int32 Id { get; private set; }
        
        public T GetComponent<T>(string name)
        {
            try
            {
                return (T)(Components.Where(c => c.Name == name).FirstOrDefault());
            }
            catch (InvalidCastException i)
            {
                return default(T);
            }
        }

        private static Int32 __nextId = 0;
        private static Int32 GetNextId()
        {
            return ++__nextId;
        }

        public void Update(UpdateEventArgs args)
        {
            CurrentState.Update(this, args);
        }
    }
}
