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
    public partial class Part4 : Form
    {
        public int seconds;
        public int minutes;
        public int hour;
        public Part4()
        {
            InitializeComponent();
        }

        private void Hintbtn1_Click(object sender, EventArgs e)
        {
            hintPanel1.Visible = true;
        }

        private void BtnEnterCode1_Click(object sender, EventArgs e)
        {
            string code = answerBox1.Text.ToUpper();

            if (code == "MAC")
            {
                MessageBox.Show("Are you the chosen one?");
                panel3.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                //PENALIZE
                MessageBox.Show("ACCESS DENIED !! - TIME IS RUNNING OUT");

                minutes = minutes - 1;
                Minute_lbl.Text = minutes.ToString();

                if (minutes < 0)
                {
                    int temp = 0;
                    Minute_lbl.Text = temp.ToString();

                    seconds = seconds - seconds;
                    Second_lbl.Text = seconds.ToString();
                    if (seconds == 0)
                    {
                        //MessageBox.Show("Ran out of time please try again.");
                    }
                }
            }

        }

        private void OkBtn1_Click(object sender, EventArgs e)
        {
            hintPanel1.Visible = false;
        }
        private void Part4_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;

            //DECLARE & INITIALIZE LABEL VARIABLES
            seconds = int.Parse(Second_lbl.Text);
            minutes = int.Parse(Minute_lbl.Text);
            hour = int.Parse(Hour_lbl.Text);

            //INITIALIZE VARIABLES
            seconds = 0;
            minutes = 2;
            hour = 0;

            //PASS VALUES TO LABELS
            Hour_lbl.Text = hour.ToString();
            Minute_lbl.Text = minutes.ToString();
            Second_lbl.Text = seconds.ToString();

            //START COUNT DOWN
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            seconds = int.Parse(Second_lbl.Text);
            minutes = int.Parse(Minute_lbl.Text);
            hour = int.Parse(Hour_lbl.Text);

            timer1.Interval = 1000;
            if (Hour_lbl.Text == "")
                Hour_lbl.Text = "0";
            if (Minute_lbl.Text == "")
                Minute_lbl.Text = "0";
            if (Second_lbl.Text == "")
                Second_lbl.Text = "0";
            if (Hour_lbl.Text == "00")
                Hour_lbl.Text = "0";
            if (Minute_lbl.Text == "00")
                Minute_lbl.Text = "0";
            if (Second_lbl.Text == "00")
                Second_lbl.Text = "0";
            if (seconds > 0)
            {
                seconds = seconds - 1;
                Second_lbl.Text = seconds.ToString();
            }
            if (minutes > 0)
            {
                if (Second_lbl.Text == "0")
                {
                    minutes = minutes - 1;
                    Minute_lbl.Text = minutes.ToString();
                    Second_lbl.Text = "59";
                }
            }

            if (hour > 0)
            {
                if (Minute_lbl.Text == "0")
                {
                    if (Second_lbl.Text == "0")
                    {
                        hour = hour - 1;
                        Hour_lbl.Text = hour.ToString();
                        Minute_lbl.Text = "59";
                        Second_lbl.Text = "59";
                    }
                }
            }

            if (Second_lbl.Text == "0")
            {
                if (Minute_lbl.Text == "0")
                {
                    if (Hour_lbl.Text == "0")
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Ran out of time.... EXITING... ");
                        Application.Exit();
                    }
                }
            }
        }

        private void HintBtn2_Click(object sender, EventArgs e)
        {
            hintPanel2.Visible = true;
        }

        private void BtnEnterCode2_Click(object sender, EventArgs e)
        {
            string code = answerBox2.Text.ToUpper();

            if (code == "UNLOCKED")
            {
                MessageBox.Show("You're Free !");
                timer1.Enabled = false;
            }
            else
            {
                //PENALIZE
                MessageBox.Show("ACCESS DENIED !! - TIME IS RUNNING OUT");

                minutes = minutes - 1;
                Minute_lbl.Text = minutes.ToString();

                if (minutes < 0)
                {
                    int temp = 0;
                    Minute_lbl.Text = temp.ToString();

                    seconds = seconds - seconds;
                    Second_lbl.Text = seconds.ToString();
                    if (seconds == 0)
                    {
                        //MessageBox.Show("Ran out of time please try again.");
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hintPanel2.Visible = false;
        }
    }
}
