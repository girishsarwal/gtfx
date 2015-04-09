using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimDX;
using gtfx;
namespace gtfx.designer
{
    public partial class DesignViewPortWindow : Form
    {
        
        public DesignViewPortWindow()
        {
            InitializeComponent();
            Renderer.Instance.Initialize("Design Mode", panelRenderSurface.Handle);
        }

        
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DesignViewPort_Load(object sender, EventArgs e)
        {
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
