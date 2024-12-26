namespace thrive
{
    partial class exercise
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
            exlable = new Label();
            SuspendLayout();
            // 
            // exlable
            // 
            exlable.AutoSize = true;
            exlable.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exlable.ForeColor = SystemColors.Highlight;
            exlable.Location = new Point(164, 62);
            exlable.Name = "exlable";
            exlable.Size = new Size(309, 51);
            exlable.TabIndex = 0;
            exlable.Text = "Exercise Board";
            exlable.Click += label1_Click;
            // 
            // exercise
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 754);
            Controls.Add(exlable);
            Name = "exercise";
            Text = "exercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exlable;
    }
}