using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DockAndAnchorExample
{
    public partial class DockingForm : Form
    {
        public DockingForm()
        {
            InitializeComponent();
        }

        private void lblTopDock_Click(object sender, EventArgs e)
        {
            this.lblTopDock.Height = (lblTopDock.Height == 22) ? 54 : 22;
        }

        private void lblBottomDock_Click(object sender, EventArgs e)
        {
            this.lblBottomDock.Height = (lblBottomDock.Height == 22) ? 54 : 22;
        }
    }
}