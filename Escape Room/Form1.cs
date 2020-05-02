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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Hour_txt.Text = null;
            Minute_txt.Text = null;
            Second_txt.Text = null;
            Hour_lbl.Text = "00";
            Minute_lbl.Text = "00";
            Second_lbl.Text = "00";
            Stop_btn.Enabled = true;
            Start_btn.Enabled = true;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Question1_txt.Text = null;
            Question2_txt.Text = null;
            Question3_txt.Text = null;
            Question4_txt.Text = null;
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            if (Stop_btn.Text == "Stop")
            {
                timer1.Enabled = false;
                Stop_btn.Enabled = false;
                Start_btn.Enabled = true;

            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            int seconds = int.Parse(Second_lbl.Text);
            int minutes = int.Parse(Minute_lbl.Text);
            int hour = int.Parse(Hour_lbl.Text);

            
            //Start the count down
            if (Start_btn.Text == "Start")
            {
                timer1.Enabled = true;
                Start_btn.Enabled = false;
                Stop_btn.Enabled = true; 
            }

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            int seconds = int.Parse(Second_lbl.Text);
            int minutes = int.Parse(Minute_lbl.Text);
            int hour = int.Parse(Hour_lbl.Text);

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
                        MessageBox.Show("Ran out of time");
                        Start_btn.Text = "Start";
                        Start_btn.Enabled = true;
                        Stop_btn.Enabled = false;
                    }
                }
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if(Question1_txt.Text == "true" || Question1_txt.Text == "True")
            {
                MessageBox.Show("Correct Answer Question 1");
                if (Question2_txt.Text == "true" || Question2_txt.Text == "True")
                {
                    MessageBox.Show("Correct Answer Question 2");
                    if (Question3_txt.Text == "true" || Question3_txt.Text == "True")
                    {
                        MessageBox.Show("Correct Answer Question 3");
                        if(Question4_txt.Text == "true" || Question3_txt.Text == "True")
                        {
                            MessageBox.Show("Congratz! u have now made it to the next level");
                            DefaultForm obj2 = new DefaultForm();
                            obj2.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect answer for question 4");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect answer for question 3");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Answer for Question 2");
                }
            }
            else
            {
                MessageBox.Show("Incorrect answer for Question 1");
            }

        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            int seconds = int.Parse(Second_lbl.Text);
            int minutes = int.Parse(Minute_lbl.Text);
            int hour = int.Parse(Hour_lbl.Text);

            //Set countdown values
            if (Second_txt.Text == "00")
            {
                if (Minute_txt.Text == "00")
                {
                    if (Hour_txt.Text == "00")
                    {
                        Start_btn.Enabled = false;
                        MessageBox.Show("Please enter a value greater than 0");
                    }
                }
            }
            if (Second_txt.Text == "0")
            {
                if (Minute_txt.Text == "0")
                {
                    if (Hour_txt.Text == "0")
                    {
                        Start_btn.Enabled = false;
                        MessageBox.Show("Please enter a value greater than 0");
                    }
                }
            }
            if (Second_txt.Text == "")
            {
                Minute_txt.Text = "";
                Hour_txt.Text = "";
                Start_btn.Enabled = false;
                MessageBox.Show("Please enter a value");
            }

            Start_btn.Enabled = true;
            Hour_lbl.Text = Hour_txt.Text;
            Minute_lbl.Text = Minute_txt.Text;
            Second_lbl.Text = Second_txt.Text;

            if (hour > 0)
            {
                Start_btn.Enabled = true;
            }
            if (minutes > 0)
            {
                Start_btn.Enabled = true;
            }
            if (seconds > 0)
            {
                Start_btn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DECLARE & INITIALIZE LABEL VARIABLES
            int seconds = int.Parse(Second_lbl.Text);
            int minutes = int.Parse(Minute_lbl.Text);
            int hour = int.Parse(Hour_lbl.Text);

            //INITIALIZE VARIABLES
            seconds = 0;
            minutes = 10;
            hour = 0;

            Hour_lbl.Text = Hour_txt.Text;
            Minute_lbl.Text = Minute_txt.Text;
            Second_lbl.Text = Second_txt.Text;
        }
    }
}
