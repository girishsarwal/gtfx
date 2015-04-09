using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class SceneManagerFactory
    {
        public static void CreateFPS()
        {
            SceneNodeCollection nodeRoot = (SceneNodeCollection)SceneManager.Instance.CurrentScene.Root;
            SceneNode sceneSkyBox = new SceneNode("BACKGROUNDS");
            SceneNodeCollection sceneObjectsRoot = new SceneNodeCollection("SCENE OBJECTS");
            SceneNodeCollection sceneCameras = new SceneNodeCollection("CAMERAS");
            SceneNodeCollection sceneGuiElements = new SceneNodeCollection() { Name = "GUI OBJECTS" };
            SceneNodeCollection sceneCursors = new SceneNodeCollection() { Name = "OVERLAYS" };

            nodeRoot.Add(sceneSkyBox);
            nodeRoot.Add(sceneObjectsRoot);
            nodeRoot.Add(sceneCameras);
            nodeRoot.Add(sceneGuiElements);
            nodeRoot.Add(sceneCursors);
        }
    }
}
