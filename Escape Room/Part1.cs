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
        public int seconds;
        public int minutes;
        public int hour;

        public Part1()
        {
            InitializeComponent();
        }

        private void Nxtbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Phishing" || textBox1.Text == "phishing" || textBox1.Text == "PHISHHING")
            {
                MessageBox.Show("Correct");

            }
            else
            {
                MessageBox.Show("Incorrect");

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
            //MessageBox.Show("Loading Second Page");
            //panel1.Hide();
           // panel2.Show();
        }

        private void Part1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100, 100);
            
                //DECLARE & INITIALIZE LABEL VARIABLES
                seconds = int.Parse(Second_lbl.Text);
                minutes = int.Parse(Minute_lbl.Text);
                hour = int.Parse(Hour_lbl.Text);

                //INITIALIZE VARIABLES
                seconds = 0;
                minutes = 10;
                hour = 0;

                //PASS VALUES TO LABELS
                Hour_lbl.Text = hour.ToString();
                Minute_lbl.Text = minutes.ToString();
                Second_lbl.Text = seconds.ToString();

                //START COUNT DOWN
                timer1.Enabled = true;
            
            // panel2.BackColor = Color.FromArgb(100, 100, 100, 100);
        }

        private void hintbtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HINT HERE");
        }

        private void timer1_Tick(object sender, EventArgs e)
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
    }

}
