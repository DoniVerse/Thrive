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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.BackColor = Color.White;
            LogLbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogLbl.ForeColor = SystemColors.Highlight;
            LogLbl.Location = new Point(492, 43);
            LogLbl.Margin = new Padding(4, 0, 4, 0);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(95, 33);
            LogLbl.TabIndex = 0;
            LogLbl.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(439, 252);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 40);
            textBox1.TabIndex = 1;
            // 
            // ButLog
            // 
            ButLog.BackColor = SystemColors.Highlight;
            ButLog.FlatStyle = FlatStyle.Flat;
            ButLog.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButLog.ForeColor = Color.White;
            ButLog.Location = new Point(480, 373);
            ButLog.Margin = new Padding(4, 5, 4, 5);
            ButLog.Name = "ButLog";
            ButLog.Size = new Size(107, 57);
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
            PwdLbl.Location = new Point(279, 252);
            PwdLbl.Margin = new Padding(4, 0, 4, 0);
            PwdLbl.Name = "PwdLbl";
            PwdLbl.Size = new Size(122, 27);
            PwdLbl.TabIndex = 3;
            PwdLbl.Text = "Password";
            PwdLbl.Click += label2_Click;
            // 
            // UsrLbl
            // 
            UsrLbl.AutoSize = true;
            UsrLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsrLbl.ForeColor = SystemColors.Highlight;
            UsrLbl.Location = new Point(279, 167);
            UsrLbl.Margin = new Padding(4, 0, 4, 0);
            UsrLbl.Name = "UsrLbl";
            UsrLbl.Size = new Size(130, 27);
            UsrLbl.TabIndex = 4;
            UsrLbl.Text = "UserName";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(439, 166);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 40);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 516);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(410, 510);
            label2.Name = "label2";
            label2.Size = new Size(282, 33);
            label2.TabIndex = 7;
            label2.Text = "Don't have an Account ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(439, 583);
            label3.Name = "label3";
            label3.Size = new Size(197, 27);
            label3.TabIndex = 8;
            label3.Text = "Create An Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(UsrLbl);
            Controls.Add(PwdLbl);
            Controls.Add(ButLog);
            Controls.Add(textBox1);
            Controls.Add(LogLbl);
            Cursor = Cursors.Cross;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Padding = new Padding(5, 6, 5, 5);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}