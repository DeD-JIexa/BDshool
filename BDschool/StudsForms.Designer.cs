namespace BDschool
{
    partial class StudsForms
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
            this.schoolDataSet = new BDschool.SchoolDataSet();
            this.studsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studsTableAdapter = new BDschool.SchoolDataSetTableAdapters.StudsTableAdapter();
            this.idSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudsAdd = new System.Windows.Forms.Button();
            this.DelStudBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSDataGridViewTextBoxColumn,
            this.nameSDataGridViewTextBoxColumn,
            this.surNameSDataGridViewTextBoxColumn,
            this.idClDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studsBindingSource
            // 
            this.studsBindingSource.DataMember = "Studs";
            this.studsBindingSource.DataSource = this.schoolDataSet;
            // 
            // studsTableAdapter
            // 
            this.studsTableAdapter.ClearBeforeFill = true;
            // 
            // idSDataGridViewTextBoxColumn
            // 
            this.idSDataGridViewTextBoxColumn.DataPropertyName = "IdS";
            this.idSDataGridViewTextBoxColumn.HeaderText = "IdS";
            this.idSDataGridViewTextBoxColumn.Name = "idSDataGridViewTextBoxColumn";
            this.idSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameSDataGridViewTextBoxColumn
            // 
            this.nameSDataGridViewTextBoxColumn.DataPropertyName = "NameS";
            this.nameSDataGridViewTextBoxColumn.HeaderText = "NameS";
            this.nameSDataGridViewTextBoxColumn.Name = "nameSDataGridViewTextBoxColumn";
            // 
            // surNameSDataGridViewTextBoxColumn
            // 
            this.surNameSDataGridViewTextBoxColumn.DataPropertyName = "SurNameS";
            this.surNameSDataGridViewTextBoxColumn.HeaderText = "SurNameS";
            this.surNameSDataGridViewTextBoxColumn.Name = "surNameSDataGridViewTextBoxColumn";
            // 
            // idClDataGridViewTextBoxColumn
            // 
            this.idClDataGridViewTextBoxColumn.DataPropertyName = "idCl";
            this.idClDataGridViewTextBoxColumn.HeaderText = "idCl";
            this.idClDataGridViewTextBoxColumn.Name = "idClDataGridViewTextBoxColumn";
            // 
            // StudsAdd
            // 
            this.StudsAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.StudsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudsAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudsAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StudsAdd.Location = new System.Drawing.Point(12, 370);
            this.StudsAdd.Name = "StudsAdd";
            this.StudsAdd.Size = new System.Drawing.Size(142, 38);
            this.StudsAdd.TabIndex = 1;
            this.StudsAdd.Text = "Add Stud";
            this.StudsAdd.UseVisualStyleBackColor = false;
            this.StudsAdd.Click += new System.EventHandler(this.StudsAdd_Click);
            // 
            // DelStudBut
            // 
            this.DelStudBut.BackColor = System.Drawing.Color.DarkBlue;
            this.DelStudBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DelStudBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelStudBut.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelStudBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DelStudBut.Location = new System.Drawing.Point(413, 370);
            this.DelStudBut.Name = "DelStudBut";
            this.DelStudBut.Size = new System.Drawing.Size(142, 38);
            this.DelStudBut.TabIndex = 2;
            this.DelStudBut.Text = "Del Stud";
            this.DelStudBut.UseVisualStyleBackColor = false;
            this.DelStudBut.Click += new System.EventHandler(this.DelStudBut_Click);
            // 
            // StudsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.DelStudBut);
            this.Controls.Add(this.StudsAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudsForms";
            this.Text = "StudsForms";
            this.Load += new System.EventHandler(this.StudsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studsBindingSource;
        private SchoolDataSetTableAdapters.StudsTableAdapter studsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button StudsAdd;
        private System.Windows.Forms.Button DelStudBut;
    }
}