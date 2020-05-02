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
    public partial class Part1 : Form
    {
        //List<Panel> ListPanel = new List<Panel>();

        public Part1()
        {
            InitializeComponent();
        }

        private void Nxtbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Second Page");
            panel1.Hide();
           // panel2.Show();
        }

        private void Part1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100, 100);
           // panel2.BackColor = Color.FromArgb(100, 100, 100, 100);
        }

        private void hintbtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HINT HERE");
        }

    }

}
