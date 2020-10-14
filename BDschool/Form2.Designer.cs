namespace BDschool
{
    partial class Form2
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.ClassStudBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddStudsBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(93, 81);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurNameBox
            // 
            this.SurNameBox.Location = new System.Drawing.Point(93, 135);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(215, 20);
            this.SurNameBox.TabIndex = 1;
            this.SurNameBox.TextChanged += new System.EventHandler(this.SurNameBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(89, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SurNameLabel.Location = new System.Drawing.Point(89, 110);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(87, 22);
            this.SurNameLabel.TabIndex = 3;
            this.SurNameLabel.Text = "SurName:";
            this.SurNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassStudBox
            // 
            this.ClassStudBox.AutoSize = true;
            this.ClassStudBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassStudBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassStudBox.Location = new System.Drawing.Point(89, 158);
            this.ClassStudBox.Name = "ClassStudBox";
            this.ClassStudBox.Size = new System.Drawing.Size(56, 22);
            this.ClassStudBox.TabIndex = 4;
            this.ClassStudBox.Text = "Class:";
            this.ClassStudBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddStudsBut
            // 
            this.AddStudsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.AddStudsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddStudsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddStudsBut.Location = new System.Drawing.Point(93, 210);
            this.AddStudsBut.Name = "AddStudsBut";
            this.AddStudsBut.Size = new System.Drawing.Size(215, 38);
            this.AddStudsBut.TabIndex = 6;
            this.AddStudsBut.Text = "Add Stud";
            this.AddStudsBut.UseVisualStyleBackColor = false;
            this.AddStudsBut.Click += new System.EventHandler(this.AddStudsBut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(427, 276);
            this.Controls.Add(this.AddStudsBut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClassStudBox);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label ClassStudBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddStudsBut;
    }
}