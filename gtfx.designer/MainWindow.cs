using gtfx;
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
    public partial class MainWindow : Form, IStateMachine
    {

        
        public DesignViewPortWindow DesignViewPort { get; set; }
        public ExplorerWindow Explorer { get; set; }
        public OutputWindow Output { get; set; }
        public InspectorWindow Inspector { get; set; }
        public IState CurrentState { get; set; }
        public IState PreviousState { get; set; }

        public Boolean IsProjectOpen { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DesignViewPort = new DesignViewPortWindow();
            Explorer = new ExplorerWindow();
            Output = new OutputWindow();
            Inspector = new InspectorWindow();

            Explorer.EntitySelected += Explorer_EntitySelected;

        }

        void Explorer_EntitySelected(object sender, ExplorerWindow.EntitySelectedEventArgs e)
        {
            Inspector.Target = e.EntitySelected;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consoleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Output.IsDisposed)
            {
                Output = new OutputWindow();
            }
            if (consoleToolStripMenuItem.Checked)
            {
                Output.MdiParent = this;
                //Output.Dock = DockStyle.Bottom;
                Output.Show();
            }
            else
                Output.Hide();

        }

        private void explorerToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Explorer.IsDisposed)
            {
                Explorer = new ExplorerWindow();
            }
            if (explorerToolStripMenuItem.Checked)
            {
                Explorer.MdiParent = this;
                //Explorer.Dock = DockStyle.Left;
                Explorer.Show();
            }
            else
                Explorer.Hide();

        }

        private void designViewportToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignViewPort.IsDisposed)
            {
                DesignViewPort = new DesignViewPortWindow();
            }
            if (designViewportToolStripMenuItem.Checked)
            {
                DesignViewPort.MdiParent = this;
                //DesignViewPort.Dock = DockStyle.Fill;
                DesignViewPort.Show();
            }
            else
                DesignViewPort.Hide();
        }

        private void inspectorToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Inspector.IsDisposed)
            {
                Inspector = new InspectorWindow();
            }
            if (inspectorToolStripMenuItem.Checked)
            {
                Inspector.MdiParent = this;
                //Inspector.Dock = DockStyle.Right;
                Inspector.Show();
                
            }
            else
                Inspector.Hide();
        }

        private void defaultLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolboxToolStripMenuItem.Checked = true;
            inspectorToolStripMenuItem.Checked = true;
            consoleToolStripMenuItem.Checked = true;
            explorerToolStripMenuItem.Checked = true;
            designViewportToolStripMenuItem.Checked = true;

            SceneManagerFactory.CreateFPS();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit?","Question", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
