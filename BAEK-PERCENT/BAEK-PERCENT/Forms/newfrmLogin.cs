using BAEK_PERCENT.Class.Types;
using BAEK_PERCENT.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace BAEK_PERCENT.Forms
{
    public partial class newfrmLogin : MaterialForm
    {
        public newfrmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            txtUsername.Focus();
        }

        private void Authenticate()
        {
            UserRole? tempRole = LoginDAL.TryLogin(txtUsername.Text, txtPassword.Text);

            if (tempRole.HasValue)
            {
                Program.FormControl.mainForm
                    .currentRole = tempRole.Value;

                // usernameTextBox.Clear();
                txtPassword.Clear();
                lblError.Hide();

                Program.FormControl.CurrentForm
                    = Program.FormControl.mainForm;
            }
            else
            {
                lblError.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}