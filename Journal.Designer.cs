namespace thrive
{
    partial class Journal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AddBut = new Button();
            JournalDtaGrid = new DataGridView();
            DelBut = new Button();
            ((System.ComponentModel.ISupportInitialize)JournalDtaGrid).BeginInit();
            SuspendLayout();
            // 
            // AddBut
            // 
            AddBut.BackColor = SystemColors.Highlight;
            AddBut.FlatStyle = FlatStyle.Flat;
            AddBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBut.ForeColor = Color.Transparent;
            AddBut.Location = new Point(42, 78);
            AddBut.Name = "AddBut";
            AddBut.Size = new Size(75, 35);
            AddBut.TabIndex = 0;
            AddBut.Text = "Add";
            AddBut.UseVisualStyleBackColor = false;
            AddBut.Click += AddBut_Click;
            // 
            // JournalDtaGrid
            // 
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            JournalDtaGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            JournalDtaGrid.BackgroundColor = Color.WhiteSmoke;
            JournalDtaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JournalDtaGrid.Location = new Point(197, 1);
            JournalDtaGrid.Name = "JournalDtaGrid";
            JournalDtaGrid.Size = new Size(601, 456);
            JournalDtaGrid.TabIndex = 1;
            JournalDtaGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DelBut
            // 
            DelBut.BackColor = SystemColors.Highlight;
            DelBut.FlatStyle = FlatStyle.Flat;
            DelBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelBut.ForeColor = Color.Transparent;
            DelBut.Location = new Point(42, 178);
            DelBut.Name = "DelBut";
            DelBut.Size = new Size(75, 35);
            DelBut.TabIndex = 2;
            DelBut.Text = "Delete";
            DelBut.UseVisualStyleBackColor = false;
            DelBut.Click += DelBut_Click;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DelBut);
            Controls.Add(JournalDtaGrid);
            Controls.Add(AddBut);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Journal";
            Text = "Journal";
            ((System.ComponentModel.ISupportInitialize)JournalDtaGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddBut;
        private DataGridView JournalDtaGrid;
        private Button DelBut;
    }
}