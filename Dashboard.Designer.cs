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
            moodlb = new LinkLabel();
            Dashlb = new LinkLabel();
            Journallb = new LinkLabel();
            Excericselb = new LinkLabel();
            soundlb = new LinkLabel();
            logubtn = new Button();
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
            DashPnl.Size = new Size(1059, 953);
            DashPnl.TabIndex = 0;
            DashPnl.Paint += DashPnl_Paint;
            // 
            // PanelLbl
            // 
            PanelLbl.AutoSize = true;
            PanelLbl.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PanelLbl.ForeColor = Color.Transparent;
            PanelLbl.Location = new Point(340, 10);
            PanelLbl.Margin = new Padding(5, 0, 5, 0);
            PanelLbl.Name = "PanelLbl";
            PanelLbl.Size = new Size(146, 48);
            PanelLbl.TabIndex = 0;
            PanelLbl.Text = "Thrive";
            // 
            // moodlb
            // 
            moodlb.ActiveLinkColor = SystemColors.ActiveCaption;
            moodlb.AutoSize = true;
            moodlb.DisabledLinkColor = Color.WhiteSmoke;
            moodlb.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moodlb.LinkColor = SystemColors.ActiveCaption;
            moodlb.Location = new Point(24, 93);
            moodlb.Name = "moodlb";
            moodlb.Size = new Size(160, 26);
            moodlb.TabIndex = 7;
            moodlb.TabStop = true;
            moodlb.Text = "Mood Tracker";
            moodlb.VisitedLinkColor = SystemColors.ActiveCaption;
            // 
            // Dashlb
            // 
            Dashlb.ActiveLinkColor = SystemColors.ActiveCaption;
            Dashlb.AutoSize = true;
            Dashlb.LinkColor = SystemColors.ActiveCaption;
            Dashlb.Location = new Point(24, 39);
            Dashlb.Name = "Dashlb";
            Dashlb.Size = new Size(148, 28);
            Dashlb.TabIndex = 8;
            Dashlb.TabStop = true;
            Dashlb.Text = "Dash Board";
            Dashlb.VisitedLinkColor = SystemColors.ActiveCaption;
            // 
            // Journallb
            // 
            Journallb.AutoSize = true;
            Journallb.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Journallb.LinkColor = SystemColors.ActiveCaption;
            Journallb.Location = new Point(30, 143);
            Journallb.Name = "Journallb";
            Journallb.Size = new Size(108, 32);
            Journallb.TabIndex = 9;
            Journallb.TabStop = true;
            Journallb.Text = "Journal";
            Journallb.VisitedLinkColor = SystemColors.ActiveCaption;
            // 
            // Excericselb
            // 
            Excericselb.ActiveLinkColor = SystemColors.ActiveCaption;
            Excericselb.AutoSize = true;
            Excericselb.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Excericselb.LinkColor = SystemColors.ActiveCaption;
            Excericselb.Location = new Point(30, 201);
            Excericselb.Name = "Excericselb";
            Excericselb.Size = new Size(110, 33);
            Excericselb.TabIndex = 10;
            Excericselb.TabStop = true;
            Excericselb.Text = "Exercise";
            Excericselb.VisitedLinkColor = SystemColors.ActiveCaption;
            // 
            // soundlb
            // 
            soundlb.AutoSize = true;
            soundlb.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soundlb.LinkColor = SystemColors.ActiveCaption;
            soundlb.Location = new Point(30, 270);
            soundlb.Name = "soundlb";
            soundlb.Size = new Size(155, 33);
            soundlb.TabIndex = 11;
            soundlb.TabStop = true;
            soundlb.Text = "Sound Track";
            soundlb.VisitedLinkColor = SystemColors.ActiveCaption;
            // 
            // logubtn
            // 
            logubtn.BackColor = SystemColors.Highlight;
            logubtn.FlatStyle = FlatStyle.Flat;
            logubtn.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logubtn.ForeColor = Color.White;
            logubtn.Location = new Point(39, 833);
            logubtn.Name = "logubtn";
            logubtn.Size = new Size(112, 34);
            logubtn.TabIndex = 12;
            logubtn.Text = "Log Out";
            logubtn.UseVisualStyleBackColor = false;
            // 
            // DashFr
            // 
            AutoScaleDimensions = new SizeF(15F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 897);
            Controls.Add(logubtn);
            Controls.Add(soundlb);
            Controls.Add(Excericselb);
            Controls.Add(Journallb);
            Controls.Add(Dashlb);
            Controls.Add(moodlb);
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
        private LinkLabel moodlb;
        private LinkLabel Dashlb;
        private LinkLabel Journallb;
        private LinkLabel Excericselb;
        private LinkLabel soundlb;
        private Button logubtn;
    }
}