﻿namespace thrive
{
    partial class MoodHistory
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
            MoodListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MoodListView).BeginInit();
            SuspendLayout();
            // 
            // MoodListView
            // 
            MoodListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MoodListView.Location = new Point(29, 30);
            MoodListView.Name = "MoodListView";
            MoodListView.Size = new Size(737, 375);
            MoodListView.TabIndex = 2;
            MoodListView.CellContentClick += MoodListView_CellContentClick;
            // 
            // MoodHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(MoodListView);
            Name = "MoodHistory";
            Text = "MoodHistory";
            ((System.ComponentModel.ISupportInitialize)MoodListView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView MoodListView;
    }
}