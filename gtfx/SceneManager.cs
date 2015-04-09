using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneManager
        : LookupManager<string, ISceneNode>
    {
        private static SceneManager _instance = null;
        public static SceneManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SceneManager();
                return _instance;
            }
        }
        private SceneManager()
        {
            CurrentScene = new Scene();
        }

        public Scene CurrentScene
        {
            get;
            set;
        }

        public void SwitchToScene(Scene newScene)
        {
            
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

    }
    
}
