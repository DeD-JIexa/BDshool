namespace BDschool
{
    partial class LessonsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolDataSet2 = new BDschool.SchoolDataSet2();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new BDschool.SchoolDataSet2TableAdapters.LessonsTableAdapter();
            this.idLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddLessonsBut = new System.Windows.Forms.Button();
            this.DelLessonBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLDataGridViewTextBoxColumn,
            this.nameLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolDataSet2
            // 
            this.schoolDataSet2.DataSetName = "SchoolDataSet2";
            this.schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this.schoolDataSet2;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // idLDataGridViewTextBoxColumn
            // 
            this.idLDataGridViewTextBoxColumn.DataPropertyName = "IdL";
            this.idLDataGridViewTextBoxColumn.HeaderText = "IdL";
            this.idLDataGridViewTextBoxColumn.Name = "idLDataGridViewTextBoxColumn";
            // 
            // nameLDataGridViewTextBoxColumn
            // 
            this.nameLDataGridViewTextBoxColumn.DataPropertyName = "NameL";
            this.nameLDataGridViewTextBoxColumn.HeaderText = "NameL";
            this.nameLDataGridViewTextBoxColumn.Name = "nameLDataGridViewTextBoxColumn";
            // 
            // AddLessonsBut
            // 
            this.AddLessonsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.AddLessonsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddLessonsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddLessonsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLessonsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddLessonsBut.Location = new System.Drawing.Point(12, 400);
            this.AddLessonsBut.Name = "AddLessonsBut";
            this.AddLessonsBut.Size = new System.Drawing.Size(142, 38);
            this.AddLessonsBut.TabIndex = 3;
            this.AddLessonsBut.Text = "Add Lesson";
            this.AddLessonsBut.UseVisualStyleBackColor = false;
            this.AddLessonsBut.Click += new System.EventHandler(this.AddLessonsBut_Click);
            // 
            // DelLessonBut
            // 
            this.DelLessonBut.BackColor = System.Drawing.Color.DarkBlue;
            this.DelLessonBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DelLessonBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelLessonBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelLessonBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DelLessonBut.Location = new System.Drawing.Point(295, 400);
            this.DelLessonBut.Name = "DelLessonBut";
            this.DelLessonBut.Size = new System.Drawing.Size(142, 38);
            this.DelLessonBut.TabIndex = 4;
            this.DelLessonBut.Text = "Del Lesson";
            this.DelLessonBut.UseVisualStyleBackColor = false;
            this.DelLessonBut.Click += new System.EventHandler(this.DelLessonBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DelLessonBut);
            this.Controls.Add(this.AddLessonsBut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LessonsForm";
            this.Text = "LessonsForm";
            this.Load += new System.EventHandler(this.LessonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet2 schoolDataSet2;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private SchoolDataSet2TableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddLessonsBut;
        private System.Windows.Forms.Button DelLessonBut;
        private System.Windows.Forms.TextBox textBox1;
    }
}