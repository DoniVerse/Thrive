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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NoteTxtBx
            // 
            NoteTxtBx.Dock = DockStyle.Top;
            NoteTxtBx.Location = new Point(0, 0);
            NoteTxtBx.Margin = new Padding(4, 5, 4, 5);
            NoteTxtBx.Multiline = true;
            NoteTxtBx.Name = "NoteTxtBx";
            NoteTxtBx.PlaceholderText = "My Journal";
            NoteTxtBx.Size = new Size(1143, 422);
            NoteTxtBx.TabIndex = 0;
            NoteTxtBx.TextChanged += NoteTxtBx_TextChanged;
            // 
            // SaveBut
            // 
            SaveBut.BackColor = SystemColors.Highlight;
            SaveBut.FlatStyle = FlatStyle.Flat;
            SaveBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBut.ForeColor = Color.Transparent;
            SaveBut.Location = new Point(53, 442);
            SaveBut.Margin = new Padding(4, 5, 4, 5);
            SaveBut.Name = "SaveBut";
            SaveBut.Size = new Size(107, 67);
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
            BackJourBut.Location = new Point(275, 442);
            BackJourBut.Margin = new Padding(4, 5, 4, 5);
            BackJourBut.Name = "BackJourBut";
            BackJourBut.Size = new Size(189, 67);
            BackJourBut.TabIndex = 2;
            BackJourBut.Text = "Your Journal";
            BackJourBut.UseVisualStyleBackColor = false;
            BackJourBut.Click += BackJourBut_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 517);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1131, 225);
            dataGridView1.TabIndex = 3;
            // 
            // NotePad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridView1);
            Controls.Add(BackJourBut);
            Controls.Add(SaveBut);
            Controls.Add(NoteTxtBx);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NotePad";
            Text = "NotePad";
            Load += NotePad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoteTxtBx;
        private Button SaveBut;
        private Button BackJourBut;
        private DataGridView dataGridView1;
    }
}