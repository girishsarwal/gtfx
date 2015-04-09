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
            SceneManager.Instance.ItemAdded += Instance_ItemAdded;
            ShaderManager.Instance.ItemAdded += Instance_ShaderItemAdded;
        }

        void Instance_ShaderItemAdded(object sender, ShaderProgram e)
        {
            
        }

        void Instance_ItemAdded(object sender, ISceneNode e)
        {
            TreeNode node = new TreeNode()
            {
                Text = String.Format("{0}", e.Name),
                Tag = e
            };
            treeViewEntities.Nodes.Add(node);        
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
    }
}
