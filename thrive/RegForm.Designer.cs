namespace thrive
{
    partial class RegForm
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
            SignLbl = new Label();
            txtBxUsr = new TextBox();
            ButSign = new Button();
            UsrLbl = new Label();
            PwdLbl = new Label();
            CpwdLbl = new Label();
            txtBxPwd = new TextBox();
            txtBxCpwd = new TextBox();
            SuspendLayout();
            // 
            // SignLbl
            // 
            SignLbl.AutoSize = true;
            SignLbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignLbl.ForeColor = SystemColors.Highlight;
            SignLbl.Location = new Point(363, 44);
            SignLbl.Name = "SignLbl";
            SignLbl.Size = new Size(74, 22);
            SignLbl.TabIndex = 0;
            SignLbl.Text = "Signup";
            // 
            // txtBxUsr
            // 
            txtBxUsr.BackColor = SystemColors.ButtonHighlight;
            txtBxUsr.Location = new Point(384, 107);
            txtBxUsr.Name = "txtBxUsr";
            txtBxUsr.Size = new Size(202, 23);
            txtBxUsr.TabIndex = 1;
            // 
            // ButSign
            // 
            ButSign.BackColor = SystemColors.ButtonHighlight;
            ButSign.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButSign.ForeColor = SystemColors.Highlight;
            ButSign.Location = new Point(384, 275);
            ButSign.Name = "ButSign";
            ButSign.Size = new Size(75, 28);
            ButSign.TabIndex = 2;
            ButSign.Text = "Signup";
            ButSign.UseVisualStyleBackColor = false;
            // 
            // UsrLbl
            // 
            UsrLbl.AutoSize = true;
            UsrLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsrLbl.ForeColor = SystemColors.Highlight;
            UsrLbl.Location = new Point(242, 113);
            UsrLbl.Name = "UsrLbl";
            UsrLbl.Size = new Size(85, 17);
            UsrLbl.TabIndex = 3;
            UsrLbl.Text = "UserName";
            // 
            // PwdLbl
            // 
            PwdLbl.AutoSize = true;
            PwdLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PwdLbl.ForeColor = SystemColors.Highlight;
            PwdLbl.Location = new Point(242, 158);
            PwdLbl.Name = "PwdLbl";
            PwdLbl.Size = new Size(80, 17);
            PwdLbl.TabIndex = 4;
            PwdLbl.Text = "Password";
            // 
            // CpwdLbl
            // 
            CpwdLbl.AutoSize = true;
            CpwdLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CpwdLbl.ForeColor = SystemColors.Highlight;
            CpwdLbl.Location = new Point(242, 210);
            CpwdLbl.Name = "CpwdLbl";
            CpwdLbl.Size = new Size(146, 17);
            CpwdLbl.TabIndex = 5;
            CpwdLbl.Text = "Confirm Password ";
            // 
            // txtBxPwd
            // 
            txtBxPwd.BackColor = SystemColors.ButtonHighlight;
            txtBxPwd.Location = new Point(384, 158);
            txtBxPwd.Name = "txtBxPwd";
            txtBxPwd.Size = new Size(202, 23);
            txtBxPwd.TabIndex = 6;
            // 
            // txtBxCpwd
            // 
            txtBxCpwd.BackColor = SystemColors.ButtonHighlight;
            txtBxCpwd.Location = new Point(404, 210);
            txtBxCpwd.Name = "txtBxCpwd";
            txtBxCpwd.Size = new Size(221, 23);
            txtBxCpwd.TabIndex = 7;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBxCpwd);
            Controls.Add(txtBxPwd);
            Controls.Add(CpwdLbl);
            Controls.Add(PwdLbl);
            Controls.Add(UsrLbl);
            Controls.Add(ButSign);
            Controls.Add(txtBxUsr);
            Controls.Add(SignLbl);
            MaximizeBox = false;
            Name = "RegForm";
            Text = "Registration Form";
            Load += RegForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignLbl;
        private TextBox txtBxUsr;
        private Button ButSign;
        private Label UsrLbl;
        private Label PwdLbl;
        private Label CpwdLbl;
        private TextBox txtBxPwd;
        private TextBox txtBxCpwd;
    }
}