namespace HuuThanh.FAP.V2
{
    partial class ListStudents
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudentList = new DataGridView();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtGpa = new TextBox();
            lblGpa = new Label();
            txtKeyword = new TextBox();
            dgvResult = new DataGridView();
            grbSearch = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(335, 98);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowTemplate.Height = 25;
            dgvStudentList.Size = new Size(453, 390);
            dgvStudentList.TabIndex = 8;
            dgvStudentList.SelectionChanged += ViewAStudent;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 106);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(28, 165);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtId
            // 
            txtId.Location = new Point(102, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 23);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(102, 157);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 23);
            txtAddress.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddStudent;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 32);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateStudent;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(205, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteStudent;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Lime;
            btnSearch.Location = new Point(5, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += SearchStudent;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(102, 186);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(165, 23);
            txtGpa.TabIndex = 3;
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(28, 194);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(32, 15);
            lblGpa.TabIndex = 11;
            lblGpa.Text = "GPA:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(105, 40);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(170, 23);
            txtKeyword.TabIndex = 0;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 336);
            dgvResult.Name = "dgvResult";
            dgvResult.RowTemplate.Height = 25;
            dgvResult.Size = new Size(293, 152);
            dgvResult.TabIndex = 9;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(txtKeyword);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Location = new Point(7, 261);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(291, 69);
            grbSearch.TabIndex = 7;
            grbSearch.TabStop = false;
            grbSearch.Text = " Search ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 29);
            label1.Name = "label1";
            label1.Size = new Size(347, 32);
            label1.TabIndex = 12;
            label1.Text = "Student Management System";
            // 
            // ListStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(label1);
            Controls.Add(grbSearch);
            Controls.Add(dgvResult);
            Controls.Add(txtGpa);
            Controls.Add(lblGpa);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(dgvStudentList);
            Name = "ListStudents";
            Text = "List of Students";
            FormClosed += CloseApp;
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentList;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtGpa;
        private Label lblGpa;
        private TextBox txtKeyword;
        private DataGridView dgvResult;
        private GroupBox grbSearch;
        private Label label1;
    }
}
