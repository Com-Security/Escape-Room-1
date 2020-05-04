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
            String answer = textBox1.Text.ToUpper();
            if (answer == "PHISHING")
            {
                MessageBox.Show("Correct");
                panel3.Show();
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

        private void Part1_Load(object sender, EventArgs e)
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
            
            //panel3.BackColor = Color.FromArgb(100, 100, 100, 100);
        }

        private void hintbtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be ware of hyperlinks and attachments you open from emails - " +
                            "they may direct you to false websites where you're asked to " +
                            "input sensitive information");
            
            if (seconds > 0 )
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

        private void hintbtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digits and binary are an example of me. " +
                            "Traveling from person to person without moving an inch. " +
                            "A tad backward, but all part of a plan. " +
                            "Tada! Unscramble to discover with glee. ");
            
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

        private void Nxtbtn2_Click(object sender, EventArgs e)
        {
            String answer2 = textBox4.Text.ToUpper();
            if (answer2 == "DATA SHARING")
            {
                MessageBox.Show("Correct");
                MessageBox.Show("Loading Level 2");
                timer1.Enabled = false;
                Part2 obj1 = new Part2();
                obj1.Show();
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
    }

}
