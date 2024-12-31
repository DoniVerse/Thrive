namespace thrive
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
            MoodHisBackBut = new Button();
            MoodListView = new ListView();
            SuspendLayout();
            // 
            // MoodHisBackBut
            // 
            MoodHisBackBut.BackColor = SystemColors.Highlight;
            MoodHisBackBut.FlatStyle = FlatStyle.Flat;
            MoodHisBackBut.ForeColor = Color.Transparent;
            MoodHisBackBut.Location = new Point(29, 425);
            MoodHisBackBut.Name = "MoodHisBackBut";
            MoodHisBackBut.Size = new Size(75, 23);
            MoodHisBackBut.TabIndex = 1;
            MoodHisBackBut.Text = "Back";
            MoodHisBackBut.UseVisualStyleBackColor = false;
            // 
            // MoodListView
            // 
            MoodListView.Location = new Point(12, 12);
            MoodListView.Name = "MoodListView";
            MoodListView.Size = new Size(776, 389);
            MoodListView.TabIndex = 2;
            MoodListView.UseCompatibleStateImageBehavior = false;
            // 
            // MoodHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(MoodListView);
            Controls.Add(MoodHisBackBut);
            Name = "MoodHistory";
            Text = "MoodHistory";
            ResumeLayout(false);
        }

        #endregion
        private Button MoodHisBackBut;
        private ListView MoodListView;
    }
}