namespace COMP1004_F2016_Lesson8
{
    partial class ListForm2
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
            this.StudentListDataGridView = new System.Windows.Forms.DataGridView();
            this.cOMP1004DataSet = new COMP1004_F2016_Lesson8.COMP1004DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new COMP1004_F2016_Lesson8.COMP1004DataSetTableAdapters.StudentsTableAdapter();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1004DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListDataGridView
            // 
            this.StudentListDataGridView.AutoGenerateColumns = false;
            this.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.programDescriptionDataGridViewTextBoxColumn});
            this.StudentListDataGridView.DataSource = this.studentsBindingSource;
            this.StudentListDataGridView.Location = new System.Drawing.Point(12, 73);
            this.StudentListDataGridView.Name = "StudentListDataGridView";
            this.StudentListDataGridView.RowTemplate.Height = 40;
            this.StudentListDataGridView.Size = new System.Drawing.Size(545, 419);
            this.StudentListDataGridView.TabIndex = 0;
            this.StudentListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListDataGridView_CellContentClick);
            // 
            // cOMP1004DataSet
            // 
            this.cOMP1004DataSet.DataSetName = "COMP1004DataSet";
            this.cOMP1004DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.cOMP1004DataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // programDescriptionDataGridViewTextBoxColumn
            // 
            this.programDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProgramDescription";
            this.programDescriptionDataGridViewTextBoxColumn.HeaderText = "Program Description";
            this.programDescriptionDataGridViewTextBoxColumn.Name = "programDescriptionDataGridViewTextBoxColumn";
            // 
            // ListForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(577, 504);
            this.Controls.Add(this.StudentListDataGridView);
            this.Name = "ListForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListForm2";
            this.Load += new System.EventHandler(this.ListForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1004DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentListDataGridView;
        private COMP1004DataSet cOMP1004DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private COMP1004DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDescriptionDataGridViewTextBoxColumn;
    }
}