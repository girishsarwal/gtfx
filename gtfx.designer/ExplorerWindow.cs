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
        public ExplorerWindow()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            SceneManager.Instance.CurrentScene.SceneChanged += CurrentScene_SceneChanged;
        }

        void CurrentScene_SceneChanged(object sender, EventArgs e)
        {
            treeViewEntities.Nodes.Add(SceneManager.Instance.CurrentScene.ToString());    
        }

        
        private void Matetrials_Click(object sender, EventArgs e)
        {

        }
        

    }
}
