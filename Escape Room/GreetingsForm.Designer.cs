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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetingsForm));
            this.head1_lbl = new System.Windows.Forms.Label();
            this.head2_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.TextBox();
            this.Begin_lbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head1_lbl
            // 
            this.head1_lbl.AutoSize = true;
            this.head1_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head1_lbl.Location = new System.Drawing.Point(236, 52);
            this.head1_lbl.Name = "head1_lbl";
            this.head1_lbl.Size = new System.Drawing.Size(489, 71);
            this.head1_lbl.TabIndex = 0;
            this.head1_lbl.Text = "ESCAPE ROOM";
            // 
            // head2_lbl
            // 
            this.head2_lbl.AutoSize = true;
            this.head2_lbl.BackColor = System.Drawing.Color.MediumTurquoise;
            this.head2_lbl.Font = new System.Drawing.Font("Vladimir Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head2_lbl.Location = new System.Drawing.Point(276, 177);
            this.head2_lbl.Name = "head2_lbl";
            this.head2_lbl.Size = new System.Drawing.Size(379, 52);
            this.head2_lbl.TabIndex = 1;
            this.head2_lbl.Text = "Would you like a clue?";
            // 
            // Description_lbl
            // 
            this.Description_lbl.BackColor = System.Drawing.Color.Firebrick;
            this.Description_lbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.ForeColor = System.Drawing.Color.Black;
            this.Description_lbl.Location = new System.Drawing.Point(170, 266);
            this.Description_lbl.Multiline = true;
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.ReadOnly = true;
            this.Description_lbl.Size = new System.Drawing.Size(589, 196);
            this.Description_lbl.TabIndex = 3;
            this.Description_lbl.Text = resources.GetString("Description_lbl.Text");
            this.Description_lbl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Begin_lbl
            // 
            this.Begin_lbl.BackColor = System.Drawing.Color.Firebrick;
            this.Begin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin_lbl.Location = new System.Drawing.Point(324, 541);
            this.Begin_lbl.Name = "Begin_lbl";
            this.Begin_lbl.Size = new System.Drawing.Size(239, 75);
            this.Begin_lbl.TabIndex = 4;
            this.Begin_lbl.Text = "Begin";
            this.Begin_lbl.UseVisualStyleBackColor = false;
            this.Begin_lbl.Click += new System.EventHandler(this.Begin_lbl_Click);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_Room.Properties.Resources.locks;
            this.ClientSize = new System.Drawing.Size(859, 886);
            this.Controls.Add(this.Begin_lbl);
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.head2_lbl);
            this.Controls.Add(this.head1_lbl);
            this.Name = "GreetingsForm";
            this.Text = "DefaultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head1_lbl;
        private System.Windows.Forms.Label head2_lbl;
        private System.Windows.Forms.TextBox Description_lbl;
        private System.Windows.Forms.Button Begin_lbl;
    }
}