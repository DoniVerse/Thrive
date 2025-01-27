namespace thrive
{
    partial class LoginForm
    {
        private readonly DBConnection db;

        
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
            LogLbl = new Label();
            PwdTxtBx = new TextBox();
            ButLog = new Button();
            PwdLbl = new Label();
            UsrLbl = new Label();
            UsrTxtBx = new TextBox();
            label1 = new Label();
            HaveAccLbl = new Label();
            EmailLbl = new Label();
            EmailTxtBx = new TextBox();
            RegLbl = new LinkLabel();
            SuspendLayout();
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.BackColor = Color.White;
            LogLbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogLbl.ForeColor = SystemColors.Highlight;
            LogLbl.Location = new Point(344, 26);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(60, 22);
            LogLbl.TabIndex = 0;
            LogLbl.Text = "Login";
            // 
            // PwdTxtBx
            // 
            PwdTxtBx.BackColor = SystemColors.ControlLight;
            PwdTxtBx.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PwdTxtBx.Location = new Point(307, 204);
            PwdTxtBx.Name = "PwdTxtBx";
            PwdTxtBx.Size = new Size(205, 29);
            PwdTxtBx.TabIndex = 1;
            // 
            // ButLog
            // 
            ButLog.BackColor = SystemColors.Highlight;
            ButLog.FlatStyle = FlatStyle.Flat;
            ButLog.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButLog.ForeColor = Color.White;
            ButLog.Location = new Point(344, 258);
            ButLog.Name = "ButLog";
            ButLog.Size = new Size(75, 34);
            ButLog.TabIndex = 2;
            ButLog.Text = "Login";
            ButLog.UseVisualStyleBackColor = false;
            ButLog.Click += ButLog_Click;
            // 
            // PwdLbl
            // 
            PwdLbl.AutoSize = true;
            PwdLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PwdLbl.ForeColor = SystemColors.Highlight;
            PwdLbl.Location = new Point(200, 216);
            PwdLbl.Name = "PwdLbl";
            PwdLbl.Size = new Size(80, 17);
            PwdLbl.TabIndex = 3;
            PwdLbl.Text = "Password";
            PwdLbl.Click += label2_Click;
            // 
            // UsrLbl
            // 
            UsrLbl.AutoSize = true;
            UsrLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsrLbl.ForeColor = SystemColors.Highlight;
            UsrLbl.Location = new Point(195, 100);
            UsrLbl.Name = "UsrLbl";
            UsrLbl.Size = new Size(57, 17);
            UsrLbl.TabIndex = 4;
            UsrLbl.Text = "UserId";
            UsrLbl.Click += UsrLbl_Click;
            // 
            // UsrTxtBx
            // 
            UsrTxtBx.BackColor = SystemColors.ControlLight;
            UsrTxtBx.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsrTxtBx.Location = new Point(307, 100);
            UsrTxtBx.Name = "UsrTxtBx";
            UsrTxtBx.Size = new Size(205, 29);
            UsrTxtBx.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 310);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 6;
            // 
            // HaveAccLbl
            // 
            HaveAccLbl.AutoSize = true;
            HaveAccLbl.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HaveAccLbl.ForeColor = SystemColors.Highlight;
            HaveAccLbl.Location = new Point(283, 329);
            HaveAccLbl.Margin = new Padding(2, 0, 2, 0);
            HaveAccLbl.Name = "HaveAccLbl";
            HaveAccLbl.Size = new Size(193, 21);
            HaveAccLbl.TabIndex = 7;
            HaveAccLbl.Text = "Don't have an Account ?";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLbl.ForeColor = SystemColors.Highlight;
            EmailLbl.Location = new Point(195, 156);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(48, 17);
            EmailLbl.TabIndex = 9;
            EmailLbl.Text = "Email";
            // 
            // EmailTxtBx
            // 
            EmailTxtBx.BackColor = SystemColors.ControlLight;
            EmailTxtBx.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxtBx.Location = new Point(307, 151);
            EmailTxtBx.Name = "EmailTxtBx";
            EmailTxtBx.Size = new Size(205, 29);
            EmailTxtBx.TabIndex = 10;
            // 
            // RegLbl
            // 
            RegLbl.AutoSize = true;
            RegLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegLbl.LinkColor = Color.DodgerBlue;
            RegLbl.Location = new Point(490, 329);
            RegLbl.Name = "RegLbl";
            RegLbl.Size = new Size(104, 21);
            RegLbl.TabIndex = 11;
            RegLbl.TabStop = true;
            RegLbl.Text = "Register Here";
            RegLbl.LinkClicked += RegLbl_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 449);
            Controls.Add(RegLbl);
            Controls.Add(EmailTxtBx);
            Controls.Add(EmailLbl);
            Controls.Add(HaveAccLbl);
            Controls.Add(label1);
            Controls.Add(UsrTxtBx);
            Controls.Add(UsrLbl);
            Controls.Add(PwdLbl);
            Controls.Add(ButLog);
            Controls.Add(PwdTxtBx);
            Controls.Add(LogLbl);
            Cursor = Cursors.Cross;
            Name = "LoginForm";
            Padding = new Padding(4, 4, 4, 3);
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogLbl;
        private TextBox PwdTxtBx;
        private Button ButLog;
        private Label PwdLbl;
        private Label UsrLbl;
        private TextBox UsrTxtBx;
        private Label label1;
        private Label HaveAccLbl;
        private Label EmailLbl;
        private TextBox EmailTxtBx;
        private LinkLabel RegLbl;
    }
}