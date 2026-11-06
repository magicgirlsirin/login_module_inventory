namespace inventory
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lnkSignIn = new System.Windows.Forms.LinkLabel();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tblLayout.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            //
            // tblLayout  (one column: each label sits directly above its input)
            //
            this.tblLayout.AutoScroll = true;
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tblLayout.Controls.Add(this.lblSubtitle, 0, 1);
            this.tblLayout.Controls.Add(this.lblFullName, 0, 2);
            this.tblLayout.Controls.Add(this.txtFullName, 0, 3);
            this.tblLayout.Controls.Add(this.lblUsername, 0, 4);
            this.tblLayout.Controls.Add(this.txtUsername, 0, 5);
            this.tblLayout.Controls.Add(this.lblPassword, 0, 6);
            this.tblLayout.Controls.Add(this.txtPassword, 0, 7);
            this.tblLayout.Controls.Add(this.lblConfirm, 0, 8);
            this.tblLayout.Controls.Add(this.txtConfirmPassword, 0, 9);
            this.tblLayout.Controls.Add(this.lnkSignIn, 0, 10);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(12);
            this.tblLayout.RowCount = 11;
            for (int i = 0; i < 11; i++)
                this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblLayout.TabIndex = 6;
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "INVENTORY MANAGEMENT SYSTEM";
            //
            // lblSubtitle
            //
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Create your Account";
            //
            // lblFullName
            //
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Text = "Full Name:";
            //
            // txtFullName
            //
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.TabIndex = 0;
            //
            // lblUsername
            //
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username:";
            //
            // txtUsername
            //
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TabIndex = 1;
            //
            // lblPassword
            //
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password:";
            //
            // txtPassword
            //
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            this.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text = "Re-enter Password:";
            //
            // txtConfirmPassword
            //
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            //
            // lnkSignIn
            //
            this.lnkSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.TabIndex = 5;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "Already have an account? Sign in here.";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignIn_LinkClicked);
            //
            // pnlButtons
            //
            this.pnlButtons.Controls.Add(this.btnRegister);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(8);
            this.pnlButtons.Size = new System.Drawing.Size(400, 48);
            this.pnlButtons.TabIndex = 7;
            //
            // btnRegister
            //
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // RegisterForm
            //
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.tblLayout);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkSignIn;
    }
}
