namespace Escape_Room
{
    partial class TheEND
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
            this.head1_lbl = new System.Windows.Forms.Label();
            this.head2_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // head1_lbl
            // 
            this.head1_lbl.AutoSize = true;
            this.head1_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head1_lbl.Location = new System.Drawing.Point(117, 19);
            this.head1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.head1_lbl.Name = "head1_lbl";
            this.head1_lbl.Size = new System.Drawing.Size(394, 57);
            this.head1_lbl.TabIndex = 1;
            this.head1_lbl.Text = "ESCAPE ROOM";
            // 
            // head2_lbl
            // 
            this.head2_lbl.AutoSize = true;
            this.head2_lbl.BackColor = System.Drawing.Color.MediumTurquoise;
            this.head2_lbl.Font = new System.Drawing.Font("Vladimir Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head2_lbl.Location = new System.Drawing.Point(161, 143);
            this.head2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.head2_lbl.Name = "head2_lbl";
            this.head2_lbl.Size = new System.Drawing.Size(312, 42);
            this.head2_lbl.TabIndex = 2;
            this.head2_lbl.Text = "Would you like a clue?";
            // 
            // Description_lbl
            // 
            this.Description_lbl.BackColor = System.Drawing.Color.Firebrick;
            this.Description_lbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.ForeColor = System.Drawing.Color.Black;
            this.Description_lbl.Location = new System.Drawing.Point(97, 269);
            this.Description_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Description_lbl.Multiline = true;
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.ReadOnly = true;
            this.Description_lbl.Size = new System.Drawing.Size(443, 97);
            this.Description_lbl.TabIndex = 4;
            this.Description_lbl.Text = "CONGRATZ! YOU WON THE GAME. THANK YOU FOR PLAYING AND PLEASE COME AGAIN :)";
            this.Description_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Firebrick;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(220, 465);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(179, 61);
            this.Exit_btn.TabIndex = 5;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(97, 587);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(456, 84);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Designed by:                     Shandy Morris 1602956                    Erick G" +
    "entles 1602971";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TheEND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_Room.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(644, 720);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.head2_lbl);
            this.Controls.Add(this.head1_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TheEND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheEND";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head1_lbl;
        private System.Windows.Forms.Label head2_lbl;
        private System.Windows.Forms.TextBox Description_lbl;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}