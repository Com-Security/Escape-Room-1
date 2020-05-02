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
        public int seconds;
        public int minutes;
        public int hour;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Question1_txt.Text = null;
            Question2_txt.Text = null;
            Question3_txt.Text = null;
            Question4_txt.Text = null;
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

        private void Submit_btn_Click(object sender, EventArgs e)
        {
           

            
           

            if (Question1_txt.Text == "true" || Question1_txt.Text == "True")
            {
                MessageBox.Show("Correct Answer Question 1");
                
            }
            else
            {
                //MessageBox.Show("Incorrect answer for Question 1");

                //int seconds = int.Parse(Minute_lbl.Text);
                minutes = minutes - 1;
                Minute_lbl.Text = minutes.ToString();

                if (minutes < 0)
                {
                    int temp = 0;
                    Minute_lbl.Text = temp.ToString();

                    seconds = seconds - seconds;
                    Second_lbl.Text = seconds.ToString();
                    
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        }
        
    }
}
