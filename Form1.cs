using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?sxsrf=ALeKk008WtCMJQ30Fh9B3k-XMtBeGDQLvA%3A1586010186706&source=hp&ei=SpiIXvyaKbnZ5OUPqImMoA8&q=" + tBuscar.Text + "&oq=" + tBuscar.Text + "&gs_lcp=CgZwc3ktYWIQAzIHCAAQgwEQQzICCAAyAggAMgIIADIFCAAQgwEyAggAMgIIADICCAAyAggAMgIIADoECCMQJzoGCCMQJxATOgQIABBDShMIFxIPMGcxNTVnMTQ0ZzUtMjc3Sg0IGBIJMGcxZzFnNS0xUKoLWIYRYOEUaABwAHgCgAHyBIgBmQySAQswLjIuMS4wLjEuMZgBAKABAaoBB2d3cy13aXo&sclient=psy-ab&ved=0ahUKEwj856Wu_M7oAhW5LLkGHagEA_QQ4dUDCAY&uact=5");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
