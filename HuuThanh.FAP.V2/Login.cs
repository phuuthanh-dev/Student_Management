using HuuThanh.FAP.V2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuuThanh.FAP.V2
{
    public partial class Login : Form
    {
        private IUserAccountRepository _usesAcc;
        public Login()
        {
            _usesAcc = new UserAccountRepositoryMySQL();
            InitializeComponent();
        }

        private void LoginUser(object sender, EventArgs e)
        {

            UserAccount account = _usesAcc.Search(txtUsername.Text.Trim());
            if (account != null)
            {
                if (account.Password != txtPassword.Text.Trim())
                {
                    MessageBox.Show("Invalid password!", "Wrong!!!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    ListStudents mainForm = new ListStudents();
                    mainForm.Show();
                    //this.Close(); //giết cái app luôn
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("Invalid username!", "Wrong!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
