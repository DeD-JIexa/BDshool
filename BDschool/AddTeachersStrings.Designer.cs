namespace BDschool
{
    partial class AddTeachersStrings
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
            this.AddTeachearsBut = new System.Windows.Forms.Button();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTeachearsBut
            // 
            this.AddTeachearsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.AddTeachearsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTeachearsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeachearsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeachearsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTeachearsBut.Location = new System.Drawing.Point(99, 155);
            this.AddTeachearsBut.Name = "AddTeachearsBut";
            this.AddTeachearsBut.Size = new System.Drawing.Size(142, 38);
            this.AddTeachearsBut.TabIndex = 5;
            this.AddTeachearsBut.Text = "Add Teachear";
            this.AddTeachearsBut.UseVisualStyleBackColor = false;
            this.AddTeachearsBut.Click += new System.EventHandler(this.AddTeachearsBut_Click);
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SurNameLabel.Location = new System.Drawing.Point(65, 104);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(87, 22);
            this.SurNameLabel.TabIndex = 9;
            this.SurNameLabel.Text = "SurName:";
            this.SurNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(65, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SurNameBox
            // 
            this.SurNameBox.Location = new System.Drawing.Point(69, 129);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(215, 20);
            this.SurNameBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(69, 75);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 20);
            this.NameBox.TabIndex = 6;
            // 
            // AddTeachersStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(381, 265);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddTeachearsBut);
            this.Name = "AddTeachersStrings";
            this.Text = "AddTeachersStrings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTeachearsBut;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.TextBox NameBox;
    }
}