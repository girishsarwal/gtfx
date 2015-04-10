using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtfx.designer
{
    public partial class InspectorWindow : Form
    {
        public InspectorWindow()
        {
            InitializeComponent();
        }
        public object Target
        {
            get
            {
                return pgProperties.SelectedObject;
            }
            set
            {
                pgProperties.SelectedObject = value;
            }
        }
        private void Inspector_Load(object sender, EventArgs e)
        {
            
        }

        private void pgProperties_Click(object sender, EventArgs e)
        {

        }
        
    }
}
