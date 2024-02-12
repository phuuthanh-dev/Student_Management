namespace HuuThanh.FAP.V2
{
    partial class Login
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
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            grbForm = new GroupBox();
            grbForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 46);
            label1.Name = "label1";
            label1.Size = new Size(555, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Student Management System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(34, 40);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(116, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 23);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Location = new Point(116, 127);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += LoginUser;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(34, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // grbForm
            // 
            grbForm.BackColor = Color.LightGreen;
            grbForm.Controls.Add(txtPassword);
            grbForm.Controls.Add(btnLogin);
            grbForm.Controls.Add(lblPassword);
            grbForm.Controls.Add(txtUsername);
            grbForm.Controls.Add(lblUsername);
            grbForm.Location = new Point(133, 123);
            grbForm.Name = "grbForm";
            grbForm.Size = new Size(336, 199);
            grbForm.TabIndex = 6;
            grbForm.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbForm);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            grbForm.ResumeLayout(false);
            grbForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private GroupBox grbForm;
    }
}