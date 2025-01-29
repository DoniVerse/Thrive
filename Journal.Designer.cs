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
            journalGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)journalGrid).BeginInit();
            SuspendLayout();
            // 
            // journalGrid
            // 
            journalGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            journalGrid.Location = new Point(36, 42);
            journalGrid.Margin = new Padding(4, 5, 4, 5);
            journalGrid.Name = "journalGrid";
            journalGrid.RowHeadersWidth = 62;
            journalGrid.Size = new Size(1060, 650);
            journalGrid.TabIndex = 0;
            journalGrid.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(journalGrid);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Journal";
            Text = "Journal";
            Load += Journal_Load;
            ((System.ComponentModel.ISupportInitialize)journalGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView journalGrid;
    }
}