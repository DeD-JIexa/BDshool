namespace BDschool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameShoolLabel = new System.Windows.Forms.Label();
            this.StudsBut = new System.Windows.Forms.Button();
            this.ClassesBut = new System.Windows.Forms.Button();
            this.LessonsBut = new System.Windows.Forms.Button();
            this.TeachearsBut = new System.Windows.Forms.Button();
            this.JournalBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.NameShoolLabel);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 193);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.JournalBut);
            this.panel2.Controls.Add(this.TeachearsBut);
            this.panel2.Controls.Add(this.LessonsBut);
            this.panel2.Controls.Add(this.ClassesBut);
            this.panel2.Controls.Add(this.StudsBut);
            this.panel2.Location = new System.Drawing.Point(-2, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 264);
            this.panel2.TabIndex = 1;
            // 
            // NameShoolLabel
            // 
            this.NameShoolLabel.AutoSize = true;
            this.NameShoolLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameShoolLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameShoolLabel.Location = new System.Drawing.Point(239, 70);
            this.NameShoolLabel.Name = "NameShoolLabel";
            this.NameShoolLabel.Size = new System.Drawing.Size(131, 39);
            this.NameShoolLabel.TabIndex = 0;
            this.NameShoolLabel.Text = "Shool #3";
            this.NameShoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameShoolLabel.Click += new System.EventHandler(this.NameShoolLabel_Click);
            // 
            // StudsBut
            // 
            this.StudsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.StudsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StudsBut.Location = new System.Drawing.Point(14, 12);
            this.StudsBut.Name = "StudsBut";
            this.StudsBut.Size = new System.Drawing.Size(142, 38);
            this.StudsBut.TabIndex = 0;
            this.StudsBut.Text = "Studs";
            this.StudsBut.UseVisualStyleBackColor = false;
            this.StudsBut.Click += new System.EventHandler(this.StudsBut_Click);
            // 
            // ClassesBut
            // 
            this.ClassesBut.BackColor = System.Drawing.Color.DarkBlue;
            this.ClassesBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClassesBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassesBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClassesBut.Location = new System.Drawing.Point(162, 12);
            this.ClassesBut.Name = "ClassesBut";
            this.ClassesBut.Size = new System.Drawing.Size(142, 38);
            this.ClassesBut.TabIndex = 1;
            this.ClassesBut.Text = "Classes";
            this.ClassesBut.UseVisualStyleBackColor = false;
            this.ClassesBut.Click += new System.EventHandler(this.ClassesBut_Click);
            // 
            // LessonsBut
            // 
            this.LessonsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.LessonsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LessonsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LessonsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LessonsBut.Location = new System.Drawing.Point(310, 12);
            this.LessonsBut.Name = "LessonsBut";
            this.LessonsBut.Size = new System.Drawing.Size(142, 38);
            this.LessonsBut.TabIndex = 2;
            this.LessonsBut.Text = "Lessons";
            this.LessonsBut.UseVisualStyleBackColor = false;
            this.LessonsBut.Click += new System.EventHandler(this.LessonsBut_Click);
            // 
            // TeachearsBut
            // 
            this.TeachearsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.TeachearsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeachearsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeachearsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachearsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TeachearsBut.Location = new System.Drawing.Point(458, 12);
            this.TeachearsBut.Name = "TeachearsBut";
            this.TeachearsBut.Size = new System.Drawing.Size(142, 38);
            this.TeachearsBut.TabIndex = 3;
            this.TeachearsBut.Text = "Teachears";
            this.TeachearsBut.UseVisualStyleBackColor = false;
            this.TeachearsBut.Click += new System.EventHandler(this.TeachearsBut_Click);
            // 
            // JournalBut
            // 
            this.JournalBut.BackColor = System.Drawing.Color.DarkBlue;
            this.JournalBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.JournalBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JournalBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.JournalBut.Location = new System.Drawing.Point(162, 107);
            this.JournalBut.Name = "JournalBut";
            this.JournalBut.Size = new System.Drawing.Size(290, 68);
            this.JournalBut.TabIndex = 4;
            this.JournalBut.Text = "Journal";
            this.JournalBut.UseVisualStyleBackColor = false;
            this.JournalBut.Click += new System.EventHandler(this.JournalBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameShoolLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StudsBut;
        private System.Windows.Forms.Button ClassesBut;
        private System.Windows.Forms.Button LessonsBut;
        private System.Windows.Forms.Button JournalBut;
        private System.Windows.Forms.Button TeachearsBut;
    }
}

