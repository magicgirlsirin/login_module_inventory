using System;
using System.Windows.Forms;

namespace inventory
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.", "Sign In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error;
            AppUser user = UserService.SignIn(username, password, out error);
            if (user == null)
            {
                MessageBox.Show(error, "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            txtUsername.Clear();
            txtPassword.Clear();
            Hide();

            var dash = new DashboardForm(user);
            dash.FormClosed += (s, a) => Show();   // logout / close returns to sign in
            dash.Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (var reg = new RegisterForm())
                reg.ShowDialog();
            Show();
        }
    }
}
