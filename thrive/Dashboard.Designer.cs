namespace thrive
{
    partial class DashFr
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
            DashPnl = new Panel();
            PanelLbl = new Label();
            DashLbl = new Label();
            MoodLbl = new Label();
            SchduleLbl = new Label();
            JourLbl = new Label();
            SoundLbl = new Label();
            ExerLbl = new Label();
            LogLbl = new Label();
            DashPnl.SuspendLayout();
            SuspendLayout();
            // 
            // DashPnl
            // 
            DashPnl.BackColor = SystemColors.ActiveCaption;
            DashPnl.Controls.Add(PanelLbl);
            DashPnl.Location = new Point(215, -1);
            DashPnl.Margin = new Padding(5, 4, 5, 4);
            DashPnl.Name = "DashPnl";
            DashPnl.Size = new Size(1238, 605);
            DashPnl.TabIndex = 0;
            DashPnl.Paint += DashPnl_Paint;
            // 
            // PanelLbl
            // 
            PanelLbl.AutoSize = true;
            PanelLbl.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PanelLbl.ForeColor = Color.Transparent;
            PanelLbl.Location = new Point(553, 34);
            PanelLbl.Margin = new Padding(5, 0, 5, 0);
            PanelLbl.Name = "PanelLbl";
            PanelLbl.Size = new Size(97, 32);
            PanelLbl.TabIndex = 0;
            PanelLbl.Text = "Thrive";
            // 
            // DashLbl
            // 
            DashLbl.AutoSize = true;
            DashLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DashLbl.ForeColor = SystemColors.ActiveCaption;
            DashLbl.Location = new Point(30, 44);
            DashLbl.Margin = new Padding(5, 0, 5, 0);
            DashLbl.Name = "DashLbl";
            DashLbl.Size = new Size(96, 18);
            DashLbl.TabIndex = 0;
            DashLbl.Text = "Dashboard";
            // 
            // MoodLbl
            // 
            MoodLbl.AutoSize = true;
            MoodLbl.ForeColor = SystemColors.ActiveCaption;
            MoodLbl.Location = new Point(30, 103);
            MoodLbl.Margin = new Padding(5, 0, 5, 0);
            MoodLbl.Name = "MoodLbl";
            MoodLbl.Size = new Size(118, 18);
            MoodLbl.TabIndex = 2;
            MoodLbl.Text = "Mood Tracker";
            // 
            // SchduleLbl
            // 
            SchduleLbl.AutoSize = true;
            SchduleLbl.ForeColor = SystemColors.ActiveCaption;
            SchduleLbl.Location = new Point(30, 317);
            SchduleLbl.Margin = new Padding(5, 0, 5, 0);
            SchduleLbl.Name = "SchduleLbl";
            SchduleLbl.Size = new Size(80, 18);
            SchduleLbl.TabIndex = 3;
            SchduleLbl.Text = "Schduler";
            // 
            // JourLbl
            // 
            JourLbl.AutoSize = true;
            JourLbl.ForeColor = SystemColors.ActiveCaption;
            JourLbl.Location = new Point(30, 153);
            JourLbl.Margin = new Padding(5, 0, 5, 0);
            JourLbl.Name = "JourLbl";
            JourLbl.Size = new Size(68, 18);
            JourLbl.TabIndex = 4;
            JourLbl.Text = "Journal";
            // 
            // SoundLbl
            // 
            SoundLbl.AutoSize = true;
            SoundLbl.ForeColor = SystemColors.ActiveCaption;
            SoundLbl.Location = new Point(30, 266);
            SoundLbl.Margin = new Padding(5, 0, 5, 0);
            SoundLbl.Name = "SoundLbl";
            SoundLbl.Size = new Size(110, 18);
            SoundLbl.TabIndex = 5;
            SoundLbl.Text = "SoundScape";
            // 
            // ExerLbl
            // 
            ExerLbl.AutoSize = true;
            ExerLbl.ForeColor = SystemColors.ActiveCaption;
            ExerLbl.Location = new Point(30, 209);
            ExerLbl.Margin = new Padding(5, 0, 5, 0);
            ExerLbl.Name = "ExerLbl";
            ExerLbl.Size = new Size(77, 18);
            ExerLbl.TabIndex = 6;
            ExerLbl.Text = "Exercise";
            // 
            // LogLbl
            // 
            LogLbl.AutoSize = true;
            LogLbl.ForeColor = SystemColors.ActiveCaption;
            LogLbl.Location = new Point(51, 512);
            LogLbl.Name = "LogLbl";
            LogLbl.Size = new Size(64, 18);
            LogLbl.TabIndex = 1;
            LogLbl.Text = "Logout";
            // 
            // DashFr
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 539);
            Controls.Add(LogLbl);
            Controls.Add(ExerLbl);
            Controls.Add(SoundLbl);
            Controls.Add(JourLbl);
            Controls.Add(SchduleLbl);
            Controls.Add(MoodLbl);
            Controls.Add(DashLbl);
            Controls.Add(DashPnl);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DashFr";
            Text = "Dashboard";
            DashPnl.ResumeLayout(false);
            DashPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DashPnl;
        private Label PanelLbl;
        private Label DashLbl;
        private Label MoodLbl;
        private Label SchduleLbl;
        private Label JourLbl;
        private Label SoundLbl;
        private Label ExerLbl;
        private Label LogLbl;
    }
}