using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subMenu11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu1.1", "Menu1.1");
        }

        private void subMenu12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu1.2", "Menu1.2");
        }

        private void subMenu21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu2.1", "Menu2.1");
        }

        private void subMenu22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu2.2", "Menu2.2");
        }

        private void subMenu31ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu3.1", "Menu3.1");
        }

        private void subMenu32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu3.2", "Menu3.2");
        }

        private void subMenu41ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello From SubMenu4.1", "Menu4.1");
        }
    }
}
