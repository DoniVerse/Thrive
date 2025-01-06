namespace thrive
{
    partial class NotePad
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
            NoteTxtBx = new TextBox();
            SaveBut = new Button();
            BackJourBut = new Button();
            SuspendLayout();
            // 
            // NoteTxtBx
            // 
            NoteTxtBx.Dock = DockStyle.Top;
            NoteTxtBx.Location = new Point(0, 0);
            NoteTxtBx.Multiline = true;
            NoteTxtBx.Name = "NoteTxtBx";
            NoteTxtBx.PlaceholderText = "My Journal";
            NoteTxtBx.Size = new Size(800, 368);
            NoteTxtBx.TabIndex = 0;
            NoteTxtBx.TextChanged += NoteTxtBx_TextChanged;
            // 
            // SaveBut
            // 
            SaveBut.BackColor = SystemColors.Highlight;
            SaveBut.FlatStyle = FlatStyle.Flat;
            SaveBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBut.ForeColor = Color.Transparent;
            SaveBut.Location = new Point(102, 386);
            SaveBut.Name = "SaveBut";
            SaveBut.Size = new Size(75, 40);
            SaveBut.TabIndex = 1;
            SaveBut.Text = "Save";
            SaveBut.UseVisualStyleBackColor = false;
            SaveBut.Click += SaveBut_Click;
            // 
            // BackJourBut
            // 
            BackJourBut.BackColor = SystemColors.Highlight;
            BackJourBut.FlatStyle = FlatStyle.Flat;
            BackJourBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackJourBut.ForeColor = Color.Transparent;
            BackJourBut.Location = new Point(275, 386);
            BackJourBut.Name = "BackJourBut";
            BackJourBut.Size = new Size(132, 40);
            BackJourBut.TabIndex = 2;
            BackJourBut.Text = "Back to Journal";
            BackJourBut.UseVisualStyleBackColor = false;
            BackJourBut.Click += BackJourBut_Click;
            // 
            // NotePad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BackJourBut);
            Controls.Add(SaveBut);
            Controls.Add(NoteTxtBx);
            Name = "NotePad";
            Text = "NotePad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoteTxtBx;
        private Button SaveBut;
        private Button BackJourBut;
    }
}