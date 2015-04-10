using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtfx.designer
{
    public partial class ExplorerWindow : Form
    {
        public event EventHandler<EntitySelectedEventArgs> EntitySelected;
        public class EntitySelectedEventArgs
        {
            public object EntitySelected;
            public EntitySelectedEventArgs(object es)
            {
                EntitySelected = es;
            }
        }
        public ExplorerWindow()
        {
            InitializeComponent();
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            ShaderManager.Instance.ItemAdded += Instance_ShaderItemAdded;
            TreeNode root = new TreeNode();
            treeViewEntities.Nodes.Add(root);
        }

        public void ReloadExplorer()
        {
            LoadTreeFromRootNode(treeViewEntities.Nodes[0], SceneManager.Instance.CurrentScene.Root);
        }
        void LoadTreeFromRootNode(TreeNode node, SceneNode sceneNode)
        {
            if (sceneNode == null)
                return;
            node.Text = sceneNode.Name;
            node.Tag = sceneNode;
            node.Nodes.Clear();
            foreach (SceneNode item in sceneNode.Children)
            {
                TreeNode newNode = new TreeNode()
                {
                    Text = item.Name,
                    Tag = item
                };
                node.Nodes.Add(newNode);
                LoadTreeFromRootNode(newNode, item);
            }
        }

        void Instance_ShaderItemAdded(object sender, ShaderProgram e)
        {
            
        }

        void Instance_EntityItemAdded(object sender, SceneNode e)
        {

        }

        private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            OnEntitySelected(new EntitySelectedEventArgs(e.Node.Tag));
        }
        protected void OnEntitySelected(EntitySelectedEventArgs args)
        {
            
            if (EntitySelected != null)
            {
                EntitySelected(this, args);
            }

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if((treeViewEntities.SelectedNode == null)){
                MessageBox.Show("Please select a parent in the Scene for this node");
                return;
            }
            SceneNode node =(SceneNode)treeViewEntities.SelectedNode.Tag;
            SceneNode newSceneNode = new SceneNode()
            {
                Name ="New Node" + System.DateTime.Now.ToString(),
                GameObject = new GameObject()
                {
                    
                }
            };
            node.Children.Add(newSceneNode);
            LoadTreeFromRootNode(treeViewEntities.SelectedNode, node);
        }
    }
}
