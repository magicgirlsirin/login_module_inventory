using System;
using System.Windows.Forms;

namespace inventory
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (fullName == "" || username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields.", "Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            string error;
            if (!UserService.Register(fullName, username, password, out error))
            {
                MessageBox.Show(error, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Account created! You can now sign in.", "Register",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
