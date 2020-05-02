using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{
    public partial class Part2 : Form
    {
        public Part2()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
           
        }
    }
}
