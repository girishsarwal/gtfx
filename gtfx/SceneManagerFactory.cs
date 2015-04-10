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
            SceneNode nodeRoot = (SceneNode)SceneManager.Instance.CurrentScene.Root;
            SceneNode sceneSkyBox = new SceneNode("BACKGROUNDS");
            SceneNode sceneObjectsRoot = new SceneNode("SCENE OBJECTS");
            SceneNode sceneCameras = new SceneNode("CAMERAS");
            SceneNode sceneGuiElements = new SceneNode() { Name = "GUI OBJECTS" };
            SceneNode sceneCursors = new SceneNode() { Name = "OVERLAYS" };

            nodeRoot.Children.Add(sceneSkyBox);
            //nodeRoot.Children.Add(sceneObjectsRoot);
            //nodeRoot.Children.Add(sceneCameras);
            //nodeRoot.Children.Add(sceneGuiElements);
            //nodeRoot.Children.Add(sceneCursors);
        }
    }
}
