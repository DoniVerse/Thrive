namespace thrive
{
    partial class LoginForm
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
            LogLbl = new Label();
            textBox1 = new TextBox();
            ButLog = new Button();
            PwdLbl = new Label();
            UsrLbl = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogLbl.ForeColor = SystemColors.Highlight;
            LogLbl.Location = new Point(304, 24);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(60, 22);
            LogLbl.TabIndex = 0;
            LogLbl.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 1;
            // 
            // ButLog
            // 
            ButLog.BackColor = SystemColors.ButtonHighlight;
            ButLog.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButLog.ForeColor = SystemColors.Highlight;
            ButLog.Location = new Point(289, 224);
            ButLog.Name = "ButLog";
            ButLog.Size = new Size(75, 34);
            ButLog.TabIndex = 2;
            ButLog.Text = "Login";
            ButLog.UseVisualStyleBackColor = false;
            // 
            // PwdLbl
            // 
            PwdLbl.AutoSize = true;
            PwdLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PwdLbl.ForeColor = SystemColors.Highlight;
            PwdLbl.Location = new Point(192, 150);
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
            UsrLbl.Location = new Point(192, 86);
            UsrLbl.Name = "UsrLbl";
            UsrLbl.Size = new Size(85, 17);
            UsrLbl.TabIndex = 4;
            UsrLbl.Text = "UserName";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(UsrLbl);
            Controls.Add(PwdLbl);
            Controls.Add(ButLog);
            Controls.Add(textBox1);
            Controls.Add(LogLbl);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogLbl;
        private TextBox textBox1;
        private Button ButLog;
        private Label PwdLbl;
        private Label UsrLbl;
        private TextBox textBox2;
    }
}