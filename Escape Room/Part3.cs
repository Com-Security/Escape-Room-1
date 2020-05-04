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
    public partial class Part3 : Form
    {
        public int seconds;
        public int minutes;
        public int hour;

        public Part3()
        {
            InitializeComponent();

            
        }

        private void timer1_Tick_2(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 100, 100, 100);

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

        private void hintbtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Art of manipulating people so they give up confidential information.");

            if (seconds > 0)
            {
                seconds = seconds - 20;
                Second_lbl.Text = seconds.ToString();

            }
            if (seconds <= 0)
            {
                seconds = 0;
                Second_lbl.Text = seconds.ToString();
            }
        }

        private void hintbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Searching through the trash for obvious treasures like access codes or passwords.");

            if (seconds > 0)
            {
                seconds = seconds - 20;
                Second_lbl.Text = seconds.ToString();

            }
            if (seconds <= 0)
            {
                seconds = 0;
                Second_lbl.Text = seconds.ToString();
            }
        }

        private void Nextbutton2_Click(object sender, EventArgs e)
        {
            String answer2 = textBox6.Text.ToUpper();
            if (answer2 == "DUMPSTER DIVING")
            {
                MessageBox.Show("Correct");
                timer1.Enabled = false;
                Part4 obj3 = new Part4();
                obj3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect");

                seconds = seconds - 20;
                Second_lbl.Text = seconds.ToString();

                if (seconds <= 0)
                {
                    seconds = 0;
                    Second_lbl.Text = seconds.ToString();

                }
            }
        }

        private void Nxtbtn1_Click(object sender, EventArgs e)
        {
            String answer = textBox5.Text.ToUpper();
            if (answer == "SOCIAL ENGINEERING")
            {
                MessageBox.Show("Correct");
                panel6.Show();
            }
            else
            {
                MessageBox.Show("Incorrect");

                seconds = seconds - 20;
                Second_lbl.Text = seconds.ToString();

                if (seconds <= 0)
                {
                    seconds = 0;
                    Second_lbl.Text = seconds.ToString();

                }
            }
        }

    }
}
