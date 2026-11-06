using System;
using System.Windows.Forms;

namespace inventory
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(AppUser user)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + user.FullName + "!";
            lblRole.Text = "Signed in as " + user.Username + " (" + user.UserRole + ")";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close(); // SignInForm re-appears via FormClosed
        }
    }
}
