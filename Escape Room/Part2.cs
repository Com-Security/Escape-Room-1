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
        public int seconds;
        public int minutes;
        public int hour;

        public Part2()
        {
            InitializeComponent();
        }

        private void BtnEnterCode1_Click_1(object sender, EventArgs e)
        {
            string code = answerBox1.Text.ToUpper();

            if (code == "AUTHENTICATION")
            {
                MessageBox.Show("USER AUNTHENTICATED");
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

        //Hints
        private void Hintbtn1_Click_1(object sender, EventArgs e)
        {
            hintPanel1.Visible = true;
        }

        private void HintBtnOk_Click(object sender, EventArgs e)
        {
            hintPanel1.Visible = false;
        }

        private void Part2_Load(object sender, EventArgs e)
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

 

        private void Timer1_Tick_1(object sender, EventArgs e)
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

        private void BtnEnterCode2_Click(object sender, EventArgs e)
        {

            string username = answerBox2.Text.ToUpper();
            string pass = answerBox4.Text;

            if (username == "ADMIN" && pass=="admin")
            {
                MessageBox.Show(" WELCOME ADMIN MANAGER ! ");
                timer1.Enabled = false;
                //CALL PART3 FORM
                Part3 obj1 = new Part3();
                obj1.Show();
                this.Hide();
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


        private void Hintbtn2_Click(object sender, EventArgs e)
        {
            hintPanel2.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hintPanel2.Visible = false;
        }

    }

}
