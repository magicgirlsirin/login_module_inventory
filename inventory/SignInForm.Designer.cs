namespace inventory
{
    partial class SignInForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSignIn = new System.Windows.Forms.Button();
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
            this.tblLayout.Controls.Add(this.lblUsername, 0, 2);
            this.tblLayout.Controls.Add(this.txtUsername, 0, 3);
            this.tblLayout.Controls.Add(this.lblPassword, 0, 4);
            this.tblLayout.Controls.Add(this.txtPassword, 0, 5);
            this.tblLayout.Controls.Add(this.lnkRegister, 0, 6);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(12);
            this.tblLayout.RowCount = 7;
            for (int i = 0; i < 7; i++)
                this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblLayout.TabIndex = 4;
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
            this.lblSubtitle.Text = "Sign In to your Account";
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
            this.txtUsername.TabIndex = 0;
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
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lnkRegister
            //
            this.lnkRegister.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.TabIndex = 3;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Don't have an account? Register here.";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            //
            // pnlButtons
            //
            this.pnlButtons.Controls.Add(this.btnSignIn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(8);
            this.pnlButtons.Size = new System.Drawing.Size(380, 48);
            this.pnlButtons.TabIndex = 5;
            //
            // btnSignIn
            //
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(90, 30);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            //
            // SignInForm
            //
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(380, 340);
            this.Controls.Add(this.tblLayout);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}
