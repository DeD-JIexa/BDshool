namespace BDschool
{
    partial class TeachearsForm
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
            this.schoolDataSet3 = new BDschool.SchoolDataSet3();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new BDschool.SchoolDataSet3TableAdapters.TeachersTableAdapter();
            this.idTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTeachearsBut = new System.Windows.Forms.Button();
            this.DelTeacherBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTDataGridViewTextBoxColumn,
            this.nameTDataGridViewTextBoxColumn,
            this.surNameTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teachersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolDataSet3
            // 
            this.schoolDataSet3.DataSetName = "SchoolDataSet3";
            this.schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.schoolDataSet3;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // idTDataGridViewTextBoxColumn
            // 
            this.idTDataGridViewTextBoxColumn.DataPropertyName = "IdT";
            this.idTDataGridViewTextBoxColumn.HeaderText = "IdT";
            this.idTDataGridViewTextBoxColumn.Name = "idTDataGridViewTextBoxColumn";
            this.idTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameTDataGridViewTextBoxColumn
            // 
            this.nameTDataGridViewTextBoxColumn.DataPropertyName = "NameT";
            this.nameTDataGridViewTextBoxColumn.HeaderText = "NameT";
            this.nameTDataGridViewTextBoxColumn.Name = "nameTDataGridViewTextBoxColumn";
            // 
            // surNameTDataGridViewTextBoxColumn
            // 
            this.surNameTDataGridViewTextBoxColumn.DataPropertyName = "SurNameT";
            this.surNameTDataGridViewTextBoxColumn.HeaderText = "SurNameT";
            this.surNameTDataGridViewTextBoxColumn.Name = "surNameTDataGridViewTextBoxColumn";
            // 
            // AddTeachearsBut
            // 
            this.AddTeachearsBut.BackColor = System.Drawing.Color.DarkBlue;
            this.AddTeachearsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTeachearsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeachearsBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeachearsBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTeachearsBut.Location = new System.Drawing.Point(12, 400);
            this.AddTeachearsBut.Name = "AddTeachearsBut";
            this.AddTeachearsBut.Size = new System.Drawing.Size(142, 38);
            this.AddTeachearsBut.TabIndex = 4;
            this.AddTeachearsBut.Text = "Add Teachear";
            this.AddTeachearsBut.UseVisualStyleBackColor = false;
            this.AddTeachearsBut.Click += new System.EventHandler(this.AddTeachearsBut_Click);
            // 
            // DelTeacherBut
            // 
            this.DelTeacherBut.BackColor = System.Drawing.Color.DarkBlue;
            this.DelTeacherBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DelTeacherBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelTeacherBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTeacherBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DelTeacherBut.Location = new System.Drawing.Point(332, 400);
            this.DelTeacherBut.Name = "DelTeacherBut";
            this.DelTeacherBut.Size = new System.Drawing.Size(142, 38);
            this.DelTeacherBut.TabIndex = 5;
            this.DelTeacherBut.Text = "Del Teachear";
            this.DelTeacherBut.UseVisualStyleBackColor = false;
            this.DelTeacherBut.Click += new System.EventHandler(this.DelTeacherBut_Click);
            // 
            // TeachearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.DelTeacherBut);
            this.Controls.Add(this.AddTeachearsBut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeachearsForm";
            this.Text = "TeachearsForm";
            this.Load += new System.EventHandler(this.TeachearsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet3 schoolDataSet3;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private SchoolDataSet3TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddTeachearsBut;
        private System.Windows.Forms.Button DelTeacherBut;
    }
}