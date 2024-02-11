namespace HuuThanh.FAP.StudentMgt
{
    partial class StudentListForm
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
            btnSayHello = new Button();
            btnExit = new Button();
            dlgOpenFile = new OpenFileDialog();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            dgvStudentList = new DataGridView();
            btnLoadData = new Button();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            grbStudent = new GroupBox();
            btnAddnew = new Button();
            btnSearch = new Button();
            dgvResult = new DataGridView();
            txtKeyword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            grbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(12, 12);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(75, 44);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.Click += SayHello;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(111, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 44);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.Click += SayGoodbye;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            dlgOpenFile.FileOk += openFileDialog1_FileOk;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(12, 70);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(75, 44);
            btnImage.TabIndex = 2;
            btnImage.Text = "Choose Image";
            btnImage.Click += OpenImage;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.Fixed3D;
            picAvatar.Location = new Point(12, 141);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(192, 122);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(12, 123);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(46, 15);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Image: ";
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(210, 138);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowTemplate.Height = 25;
            dgvStudentList.Size = new Size(327, 282);
            dgvStudentList.TabIndex = 5;
            dgvStudentList.SelectionChanged += ShowAStudent;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(210, 107);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(75, 25);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Load Data";
            btnLoadData.Click += LoadData;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(5, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 7;
            lblId.Text = "Id:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(4, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(5, 90);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(66, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(174, 23);
            txtId.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 23);
            txtName.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(66, 90);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(174, 23);
            txtAddress.TabIndex = 12;
            // 
            // grbStudent
            // 
            grbStudent.BackColor = SystemColors.ActiveCaption;
            grbStudent.Controls.Add(txtAddress);
            grbStudent.Controls.Add(txtName);
            grbStudent.Controls.Add(txtId);
            grbStudent.Controls.Add(lblAddress);
            grbStudent.Controls.Add(lblName);
            grbStudent.Controls.Add(lblId);
            grbStudent.Location = new Point(291, 17);
            grbStudent.Name = "grbStudent";
            grbStudent.Size = new Size(246, 121);
            grbStudent.TabIndex = 13;
            grbStudent.TabStop = false;
            grbStudent.Text = "Student info";
            // 
            // btnAddnew
            // 
            btnAddnew.Location = new Point(210, 17);
            btnAddnew.Name = "btnAddnew";
            btnAddnew.Size = new Size(75, 25);
            btnAddnew.TabIndex = 14;
            btnAddnew.Text = "Add new";
            btnAddnew.Click += AddNewStudent;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(543, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.Click += SearchStudents;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(543, 138);
            dgvResult.Name = "dgvResult";
            dgvResult.RowTemplate.Height = 25;
            dgvResult.Size = new Size(250, 87);
            dgvResult.TabIndex = 16;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(624, 95);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(153, 23);
            txtKeyword.TabIndex = 14;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKeyword);
            Controls.Add(dgvResult);
            Controls.Add(btnSearch);
            Controls.Add(btnAddnew);
            Controls.Add(grbStudent);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentList);
            Controls.Add(lblFileName);
            Controls.Add(picAvatar);
            Controls.Add(btnImage);
            Controls.Add(btnExit);
            Controls.Add(btnSayHello);
            Name = "StudentListForm";
            Text = "  Student List  ";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            grbStudent.ResumeLayout(false);
            grbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnExit;
        private OpenFileDialog dlgOpenFile;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private DataGridView dgvStudentList;
        private Button btnLoadData;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private GroupBox grbStudent;
        private Button btnAddnew;
        private Button btnSearch;
        private DataGridView dgvResult;
        private TextBox txtKeyword;
    }
}
