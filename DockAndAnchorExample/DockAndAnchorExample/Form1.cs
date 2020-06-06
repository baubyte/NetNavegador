using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DockAndAnchorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDockingForm_Click(object sender, EventArgs e)
        {
            DockingForm form = new DockingForm();
            form.Show();
        }

        private void btnShowAnchoringForm_Click(object sender, EventArgs e)
        {
            AnchoringForm form = new AnchoringForm();
            form.Show();
        }
    }
}