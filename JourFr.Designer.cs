namespace thrive
{
    partial class JourFr
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
            JourDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)JourDataGrid).BeginInit();
            SuspendLayout();
            // 
            // JourDataGrid
            // 
            JourDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JourDataGrid.Location = new Point(12, 12);
            JourDataGrid.Name = "JourDataGrid";
            JourDataGrid.Size = new Size(761, 359);
            JourDataGrid.TabIndex = 0;
            JourDataGrid.CellContentClick += JourDataGrid_CellContentClick;
            // 
            // JourFr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(JourDataGrid);
            Name = "JourFr";
            Text = "JourFr";
            ((System.ComponentModel.ISupportInitialize)JourDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView JourDataGrid;
    }
}