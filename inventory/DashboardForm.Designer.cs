namespace inventory
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tblHeader.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            //
            // tblHeader  (title on the left; signed-in user and Logout on the right)
            //
            this.tblHeader.AutoSize = true;
            this.tblHeader.ColumnCount = 2;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblHeader.Controls.Add(this.lblWelcome, 0, 0);
            this.tblHeader.Controls.Add(this.pnlRight, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblHeader.TabIndex = 1;
            //
            // lblWelcome
            //
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome!";
            //
            // pnlRight
            //
            this.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlRight.AutoSize = true;
            this.pnlRight.Controls.Add(this.lblRole);
            this.pnlRight.Controls.Add(this.btnLogout);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.WrapContents = false;
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Margin = new System.Windows.Forms.Padding(3, 7, 12, 0);
            this.lblRole.Name = "lblRole";
            //
            // btnLogout
            //
            this.btnLogout.AutoSize = true;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // DashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(760, 400);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MANAGEMENT SYSTEM - Dashboard";
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.FlowLayoutPanel pnlRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
    }
}
