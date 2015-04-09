using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class GameObject
        : IStateMachine
    {
        public IState CurrentState
        {
            get;
            set;
        }

        public IState PreviousState
        {
            get;
            set;
        }

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
            Name = String.Format("GameObject {0}", Id);
            
        }

        public Int32 Id { get; private set; }
        public String Name { get; set; }

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

        public static GameObject FindByName(string name)
        {
            try
            {
                return SceneManager.Instance[name].GameObject;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public void Update(UpdateEventArgs args)
        {
            CurrentState.Update(this, args);
        }
    }
}
