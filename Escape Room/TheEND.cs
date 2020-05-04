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
    public partial class TheEND : Form
    {
        public TheEND()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void head1_lbl_Click(object sender, EventArgs e)
        {
            head1_lbl.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
