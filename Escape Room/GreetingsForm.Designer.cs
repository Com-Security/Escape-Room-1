namespace Escape_Room
{
    partial class GreetingsForm
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
            this.Begin_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // head1_lbl
            // 
            this.head1_lbl.AutoSize = true;
            this.head1_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head1_lbl.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head1_lbl.Location = new System.Drawing.Point(121, 382);
            this.head1_lbl.Name = "head1_lbl";
            this.head1_lbl.Size = new System.Drawing.Size(582, 79);
            this.head1_lbl.TabIndex = 0;
            this.head1_lbl.Text = "ESCAPE ROOM";
            // 
            // Begin_btn
            // 
            this.Begin_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Begin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin_btn.Location = new System.Drawing.Point(301, 540);
            this.Begin_btn.Name = "Begin_btn";
            this.Begin_btn.Size = new System.Drawing.Size(239, 75);
            this.Begin_btn.TabIndex = 4;
            this.Begin_btn.Text = "Begin";
            this.Begin_btn.UseVisualStyleBackColor = false;
            this.Begin_btn.Click += new System.EventHandler(this.Begin_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(121, 721);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(606, 117);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Designed by:                                          Shandy Morris 1602956      " +
    "                                                Erick Gentles 1602971";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escape_Room.Properties.Resources.PadLock_icon4;
            this.pictureBox1.Location = new System.Drawing.Point(369, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 172);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_Room.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(859, 886);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Begin_btn);
            this.Controls.Add(this.head1_lbl);
            this.Name = "GreetingsForm";
            this.Text = "DefaultForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head1_lbl;
        private System.Windows.Forms.Button Begin_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}