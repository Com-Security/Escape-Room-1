namespace Escape_Room
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Question4_txt = new System.Windows.Forms.TextBox();
            this.Question3_txt = new System.Windows.Forms.TextBox();
            this.Question2_txt = new System.Windows.Forms.TextBox();
            this.Question1_txt = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Question4_lbl = new System.Windows.Forms.Label();
            this.Question3_lbl = new System.Windows.Forms.Label();
            this.Question2_lbl = new System.Windows.Forms.Label();
            this.Question1_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Second_lbl = new System.Windows.Forms.Label();
            this.Minute_lbl = new System.Windows.Forms.Label();
            this.Hour_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Set_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Second_txt = new System.Windows.Forms.TextBox();
            this.Minute_txt = new System.Windows.Forms.TextBox();
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Question4_txt);
            this.panel1.Controls.Add(this.Question3_txt);
            this.panel1.Controls.Add(this.Question2_txt);
            this.panel1.Controls.Add(this.Question1_txt);
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.Submit_btn);
            this.panel1.Controls.Add(this.Question4_lbl);
            this.panel1.Controls.Add(this.Question3_lbl);
            this.panel1.Controls.Add(this.Question2_lbl);
            this.panel1.Controls.Add(this.Question1_lbl);
            this.panel1.Location = new System.Drawing.Point(41, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 444);
            this.panel1.TabIndex = 0;
            // 
            // Question4_txt
            // 
            this.Question4_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4_txt.Location = new System.Drawing.Point(151, 249);
            this.Question4_txt.Name = "Question4_txt";
            this.Question4_txt.Size = new System.Drawing.Size(251, 38);
            this.Question4_txt.TabIndex = 9;
            // 
            // Question3_txt
            // 
            this.Question3_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3_txt.Location = new System.Drawing.Point(151, 186);
            this.Question3_txt.Name = "Question3_txt";
            this.Question3_txt.Size = new System.Drawing.Size(251, 38);
            this.Question3_txt.TabIndex = 8;
            // 
            // Question2_txt
            // 
            this.Question2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2_txt.Location = new System.Drawing.Point(151, 123);
            this.Question2_txt.Name = "Question2_txt";
            this.Question2_txt.Size = new System.Drawing.Size(251, 38);
            this.Question2_txt.TabIndex = 7;
            // 
            // Question1_txt
            // 
            this.Question1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1_txt.Location = new System.Drawing.Point(151, 58);
            this.Question1_txt.Name = "Question1_txt";
            this.Question1_txt.Size = new System.Drawing.Size(251, 38);
            this.Question1_txt.TabIndex = 6;
            this.Question1_txt.TextChanged += new System.EventHandler(this.Question1_txt_TextChanged);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(223, 368);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(134, 37);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(64, 368);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(129, 37);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Question4_lbl
            // 
            this.Question4_lbl.AutoSize = true;
            this.Question4_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question4_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4_lbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.Question4_lbl.Location = new System.Drawing.Point(16, 252);
            this.Question4_lbl.Name = "Question4_lbl";
            this.Question4_lbl.Size = new System.Drawing.Size(109, 27);
            this.Question4_lbl.TabIndex = 3;
            this.Question4_lbl.Text = "Question 4";
            // 
            // Question3_lbl
            // 
            this.Question3_lbl.AutoSize = true;
            this.Question3_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question3_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3_lbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.Question3_lbl.Location = new System.Drawing.Point(16, 189);
            this.Question3_lbl.Name = "Question3_lbl";
            this.Question3_lbl.Size = new System.Drawing.Size(109, 27);
            this.Question3_lbl.TabIndex = 2;
            this.Question3_lbl.Text = "Question 3";
            // 
            // Question2_lbl
            // 
            this.Question2_lbl.AutoSize = true;
            this.Question2_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2_lbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.Question2_lbl.Location = new System.Drawing.Point(16, 123);
            this.Question2_lbl.Name = "Question2_lbl";
            this.Question2_lbl.Size = new System.Drawing.Size(109, 27);
            this.Question2_lbl.TabIndex = 1;
            this.Question2_lbl.Text = "Question 2";
            // 
            // Question1_lbl
            // 
            this.Question1_lbl.AutoSize = true;
            this.Question1_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1_lbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.Question1_lbl.Location = new System.Drawing.Point(16, 58);
            this.Question1_lbl.Name = "Question1_lbl";
            this.Question1_lbl.Size = new System.Drawing.Size(109, 27);
            this.Question1_lbl.TabIndex = 0;
            this.Question1_lbl.Text = "Question 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(865, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 346);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Second_lbl);
            this.groupBox2.Controls.Add(this.Minute_lbl);
            this.groupBox2.Controls.Add(this.Hour_lbl);
            this.groupBox2.Location = new System.Drawing.Point(34, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 55);
            this.label9.TabIndex = 4;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 55);
            this.label8.TabIndex = 3;
            this.label8.Text = ":";
            // 
            // Second_lbl
            // 
            this.Second_lbl.AutoSize = true;
            this.Second_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second_lbl.ForeColor = System.Drawing.Color.Red;
            this.Second_lbl.Location = new System.Drawing.Point(222, 32);
            this.Second_lbl.Name = "Second_lbl";
            this.Second_lbl.Size = new System.Drawing.Size(80, 55);
            this.Second_lbl.TabIndex = 2;
            this.Second_lbl.Text = "00";
            // 
            // Minute_lbl
            // 
            this.Minute_lbl.AutoSize = true;
            this.Minute_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minute_lbl.ForeColor = System.Drawing.Color.Red;
            this.Minute_lbl.Location = new System.Drawing.Point(126, 32);
            this.Minute_lbl.Name = "Minute_lbl";
            this.Minute_lbl.Size = new System.Drawing.Size(80, 55);
            this.Minute_lbl.TabIndex = 1;
            this.Minute_lbl.Text = "00";
            // 
            // Hour_lbl
            // 
            this.Hour_lbl.AutoSize = true;
            this.Hour_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour_lbl.ForeColor = System.Drawing.Color.Red;
            this.Hour_lbl.Location = new System.Drawing.Point(27, 32);
            this.Hour_lbl.Name = "Hour_lbl";
            this.Hour_lbl.Size = new System.Drawing.Size(80, 55);
            this.Hour_lbl.TabIndex = 0;
            this.Hour_lbl.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Set_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Second_txt);
            this.groupBox1.Controls.Add(this.Minute_txt);
            this.groupBox1.Controls.Add(this.Hour_txt);
            this.groupBox1.Controls.Add(this.Reset_btn);
            this.groupBox1.Controls.Add(this.Stop_btn);
            this.groupBox1.Controls.Add(this.Start_btn);
            this.groupBox1.Location = new System.Drawing.Point(11, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Timer";
            // 
            // Set_btn
            // 
            this.Set_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set_btn.Location = new System.Drawing.Point(282, 145);
            this.Set_btn.Name = "Set_btn";
            this.Set_btn.Size = new System.Drawing.Size(58, 36);
            this.Set_btn.TabIndex = 8;
            this.Set_btn.Text = "Set";
            this.Set_btn.UseVisualStyleBackColor = true;
            this.Set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Set:";
            // 
            // Second_txt
            // 
            this.Second_txt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Second_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second_txt.Location = new System.Drawing.Point(232, 149);
            this.Second_txt.Name = "Second_txt";
            this.Second_txt.Size = new System.Drawing.Size(43, 30);
            this.Second_txt.TabIndex = 10;
            // 
            // Minute_txt
            // 
            this.Minute_txt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Minute_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minute_txt.Location = new System.Drawing.Point(161, 148);
            this.Minute_txt.Name = "Minute_txt";
            this.Minute_txt.Size = new System.Drawing.Size(43, 30);
            this.Minute_txt.TabIndex = 9;
            // 
            // Hour_txt
            // 
            this.Hour_txt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Hour_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour_txt.Location = new System.Drawing.Point(92, 148);
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(43, 30);
            this.Hour_txt.TabIndex = 8;
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(196, 73);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(129, 46);
            this.Reset_btn.TabIndex = 7;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_btn.Location = new System.Drawing.Point(23, 73);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(129, 46);
            this.Stop_btn.TabIndex = 6;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Location = new System.Drawing.Point(108, 21);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(136, 37);
            this.Start_btn.TabIndex = 5;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_Room.Properties.Resources.locks;
            this.ClientSize = new System.Drawing.Size(1303, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Question4_lbl;
        private System.Windows.Forms.Label Question3_lbl;
        private System.Windows.Forms.Label Question2_lbl;
        private System.Windows.Forms.Label Question1_lbl;
        private System.Windows.Forms.TextBox Question4_txt;
        private System.Windows.Forms.TextBox Question3_txt;
        private System.Windows.Forms.TextBox Question2_txt;
        private System.Windows.Forms.TextBox Question1_txt;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Second_lbl;
        private System.Windows.Forms.Label Minute_lbl;
        private System.Windows.Forms.Label Hour_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.TextBox Second_txt;
        private System.Windows.Forms.TextBox Minute_txt;
        private System.Windows.Forms.TextBox Hour_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Set_btn;
    }
}

