using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class EntityManager
        : LookupManager<String, GameObject>
    {
        private static EntityManager _instance;
        public static EntityManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EntityManager();
                return _instance;
            }
        }
        private EntityManager()
        {
            
        }
    }
}
