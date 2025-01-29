namespace thrive
{
    partial class MoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoodForm));
            MoodLbl = new Label();
            FeelLbl = new Label();
            MoodPnl = new Panel();
            MoodHisBut = new Button();
            HistoryLbl = new Label();
            MoodDate = new DateTimePicker();
            LogMoodBut = new Button();
            JoyCheckBx = new CheckBox();
            SadCheckBx = new CheckBox();
            AnxiCheckBx = new CheckBox();
            FearCheckBx = new CheckBox();
            AngerCheckBx = new CheckBox();
            DisCheckBx = new CheckBox();
            JoyPicBx = new PictureBox();
            SadPicBx = new PictureBox();
            AnxiPicBx = new PictureBox();
            FearPicBx = new PictureBox();
            AngerPicBx = new PictureBox();
            disgustPicBx = new PictureBox();
            SelectLbl = new Label();
            dataGridView1 = new DataGridView();
            MoodPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JoyPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SadPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnxiPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FearPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngerPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disgustPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MoodLbl
            // 
            MoodLbl.AutoSize = true;
            MoodLbl.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MoodLbl.ForeColor = Color.Transparent;
            MoodLbl.Location = new Point(447, 15);
            MoodLbl.Margin = new Padding(4, 0, 4, 0);
            MoodLbl.Name = "MoodLbl";
            MoodLbl.Size = new Size(225, 37);
            MoodLbl.TabIndex = 0;
            MoodLbl.Text = "MoodTracker";
            // 
            // FeelLbl
            // 
            FeelLbl.AutoSize = true;
            FeelLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeelLbl.ForeColor = Color.Transparent;
            FeelLbl.Location = new Point(306, 12);
            FeelLbl.Margin = new Padding(4, 0, 4, 0);
            FeelLbl.Name = "FeelLbl";
            FeelLbl.Size = new Size(315, 27);
            FeelLbl.TabIndex = 1;
            FeelLbl.Text = "How are you feeling today?";
            // 
            // MoodPnl
            // 
            MoodPnl.BorderStyle = BorderStyle.Fixed3D;
            MoodPnl.Controls.Add(MoodHisBut);
            MoodPnl.Controls.Add(HistoryLbl);
            MoodPnl.Controls.Add(FeelLbl);
            MoodPnl.Controls.Add(MoodDate);
            MoodPnl.Controls.Add(LogMoodBut);
            MoodPnl.Controls.Add(JoyCheckBx);
            MoodPnl.Controls.Add(SadCheckBx);
            MoodPnl.Controls.Add(AnxiCheckBx);
            MoodPnl.Controls.Add(FearCheckBx);
            MoodPnl.Controls.Add(AngerCheckBx);
            MoodPnl.Controls.Add(DisCheckBx);
            MoodPnl.Controls.Add(JoyPicBx);
            MoodPnl.Controls.Add(SadPicBx);
            MoodPnl.Controls.Add(AnxiPicBx);
            MoodPnl.Controls.Add(FearPicBx);
            MoodPnl.Controls.Add(AngerPicBx);
            MoodPnl.Controls.Add(disgustPicBx);
            MoodPnl.Controls.Add(SelectLbl);
            MoodPnl.Location = new Point(52, 57);
            MoodPnl.Margin = new Padding(4, 5, 4, 5);
            MoodPnl.Name = "MoodPnl";
            MoodPnl.Size = new Size(1129, 603);
            MoodPnl.TabIndex = 2;
            MoodPnl.Paint += MoodPnl_Paint;
            // 
            // MoodHisBut
            // 
            MoodHisBut.BackColor = SystemColors.Highlight;
            MoodHisBut.FlatStyle = FlatStyle.Flat;
            MoodHisBut.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoodHisBut.ForeColor = Color.Transparent;
            MoodHisBut.Location = new Point(575, 479);
            MoodHisBut.Margin = new Padding(4, 5, 4, 5);
            MoodHisBut.Name = "MoodHisBut";
            MoodHisBut.RightToLeft = RightToLeft.No;
            MoodHisBut.Size = new Size(177, 47);
            MoodHisBut.TabIndex = 16;
            MoodHisBut.Text = "Mood History";
            MoodHisBut.UseVisualStyleBackColor = false;
            MoodHisBut.Click += MoodHisBut_Click;
            // 
            // HistoryLbl
            // 
            HistoryLbl.AutoSize = true;
            HistoryLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HistoryLbl.ForeColor = Color.Transparent;
            HistoryLbl.Location = new Point(201, 486);
            HistoryLbl.Margin = new Padding(4, 0, 4, 0);
            HistoryLbl.Name = "HistoryLbl";
            HistoryLbl.Size = new Size(366, 28);
            HistoryLbl.TabIndex = 15;
            HistoryLbl.Text = "Wanna see your mood history?";
            // 
            // MoodDate
            // 
            MoodDate.CalendarForeColor = SystemColors.ActiveCaption;
            MoodDate.Location = new Point(4, 402);
            MoodDate.Margin = new Padding(4, 5, 4, 5);
            MoodDate.Name = "MoodDate";
            MoodDate.Size = new Size(284, 31);
            MoodDate.TabIndex = 14;
            // 
            // LogMoodBut
            // 
            LogMoodBut.BackColor = SystemColors.Highlight;
            LogMoodBut.FlatStyle = FlatStyle.Flat;
            LogMoodBut.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogMoodBut.ForeColor = Color.Transparent;
            LogMoodBut.Location = new Point(367, 397);
            LogMoodBut.Margin = new Padding(4, 5, 4, 5);
            LogMoodBut.Name = "LogMoodBut";
            LogMoodBut.Size = new Size(124, 47);
            LogMoodBut.TabIndex = 13;
            LogMoodBut.Text = "Log Mood";
            LogMoodBut.UseVisualStyleBackColor = false;
            LogMoodBut.Click += LogMoodBut_Click;
            // 
            // JoyCheckBx
            // 
            JoyCheckBx.AutoSize = true;
            JoyCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JoyCheckBx.ForeColor = Color.Transparent;
            JoyCheckBx.Location = new Point(201, 329);
            JoyCheckBx.Margin = new Padding(4, 5, 4, 5);
            JoyCheckBx.Name = "JoyCheckBx";
            JoyCheckBx.Size = new Size(67, 25);
            JoyCheckBx.TabIndex = 12;
            JoyCheckBx.Text = "Joy";
            JoyCheckBx.UseVisualStyleBackColor = true;
            // 
            // SadCheckBx
            // 
            SadCheckBx.AutoSize = true;
            SadCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SadCheckBx.ForeColor = Color.Transparent;
            SadCheckBx.Location = new Point(367, 329);
            SadCheckBx.Margin = new Padding(4, 5, 4, 5);
            SadCheckBx.Name = "SadCheckBx";
            SadCheckBx.Size = new Size(70, 25);
            SadCheckBx.TabIndex = 11;
            SadCheckBx.Text = "Sad";
            SadCheckBx.UseVisualStyleBackColor = true;
            // 
            // AnxiCheckBx
            // 
            AnxiCheckBx.AutoSize = true;
            AnxiCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnxiCheckBx.ForeColor = Color.Transparent;
            AnxiCheckBx.Location = new Point(531, 329);
            AnxiCheckBx.Margin = new Padding(4, 5, 4, 5);
            AnxiCheckBx.Name = "AnxiCheckBx";
            AnxiCheckBx.Size = new Size(101, 25);
            AnxiCheckBx.TabIndex = 10;
            AnxiCheckBx.Text = "Anxiety";
            AnxiCheckBx.UseVisualStyleBackColor = true;
            AnxiCheckBx.CheckedChanged += AnxiCheckBx_CheckedChanged;
            // 
            // FearCheckBx
            // 
            FearCheckBx.AutoSize = true;
            FearCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FearCheckBx.ForeColor = Color.Transparent;
            FearCheckBx.Location = new Point(700, 339);
            FearCheckBx.Margin = new Padding(4, 5, 4, 5);
            FearCheckBx.Name = "FearCheckBx";
            FearCheckBx.Size = new Size(77, 25);
            FearCheckBx.TabIndex = 9;
            FearCheckBx.Text = "Fear";
            FearCheckBx.UseVisualStyleBackColor = true;
            // 
            // AngerCheckBx
            // 
            AngerCheckBx.AutoSize = true;
            AngerCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AngerCheckBx.ForeColor = Color.Transparent;
            AngerCheckBx.Location = new Point(879, 329);
            AngerCheckBx.Margin = new Padding(4, 5, 4, 5);
            AngerCheckBx.Name = "AngerCheckBx";
            AngerCheckBx.Size = new Size(90, 25);
            AngerCheckBx.TabIndex = 8;
            AngerCheckBx.Text = "Anger";
            AngerCheckBx.UseVisualStyleBackColor = true;
            // 
            // DisCheckBx
            // 
            DisCheckBx.AutoSize = true;
            DisCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisCheckBx.ForeColor = Color.Transparent;
            DisCheckBx.Location = new Point(21, 329);
            DisCheckBx.Margin = new Padding(4, 5, 4, 5);
            DisCheckBx.Name = "DisCheckBx";
            DisCheckBx.Size = new Size(102, 25);
            DisCheckBx.TabIndex = 7;
            DisCheckBx.Text = "Disgust";
            DisCheckBx.UseVisualStyleBackColor = true;
            // 
            // JoyPicBx
            // 
            JoyPicBx.BorderStyle = BorderStyle.FixedSingle;
            JoyPicBx.Image = (Image)resources.GetObject("JoyPicBx.Image");
            JoyPicBx.Location = new Point(201, 118);
            JoyPicBx.Margin = new Padding(4, 5, 4, 5);
            JoyPicBx.Name = "JoyPicBx";
            JoyPicBx.Size = new Size(142, 167);
            JoyPicBx.TabIndex = 6;
            JoyPicBx.TabStop = false;
            // 
            // SadPicBx
            // 
            SadPicBx.BorderStyle = BorderStyle.FixedSingle;
            SadPicBx.Image = (Image)resources.GetObject("SadPicBx.Image");
            SadPicBx.Location = new Point(367, 118);
            SadPicBx.Margin = new Padding(4, 5, 4, 5);
            SadPicBx.Name = "SadPicBx";
            SadPicBx.Size = new Size(142, 167);
            SadPicBx.TabIndex = 5;
            SadPicBx.TabStop = false;
            // 
            // AnxiPicBx
            // 
            AnxiPicBx.BorderStyle = BorderStyle.FixedSingle;
            AnxiPicBx.Image = (Image)resources.GetObject("AnxiPicBx.Image");
            AnxiPicBx.Location = new Point(531, 118);
            AnxiPicBx.Margin = new Padding(4, 5, 4, 5);
            AnxiPicBx.Name = "AnxiPicBx";
            AnxiPicBx.Size = new Size(142, 167);
            AnxiPicBx.TabIndex = 4;
            AnxiPicBx.TabStop = false;
            // 
            // FearPicBx
            // 
            FearPicBx.BorderStyle = BorderStyle.FixedSingle;
            FearPicBx.Image = (Image)resources.GetObject("FearPicBx.Image");
            FearPicBx.Location = new Point(700, 121);
            FearPicBx.Margin = new Padding(4, 5, 4, 5);
            FearPicBx.Name = "FearPicBx";
            FearPicBx.Size = new Size(142, 164);
            FearPicBx.TabIndex = 3;
            FearPicBx.TabStop = false;
            // 
            // AngerPicBx
            // 
            AngerPicBx.BorderStyle = BorderStyle.FixedSingle;
            AngerPicBx.Image = (Image)resources.GetObject("AngerPicBx.Image");
            AngerPicBx.Location = new Point(879, 121);
            AngerPicBx.Margin = new Padding(4, 5, 4, 5);
            AngerPicBx.Name = "AngerPicBx";
            AngerPicBx.Size = new Size(142, 164);
            AngerPicBx.TabIndex = 2;
            AngerPicBx.TabStop = false;
            // 
            // disgustPicBx
            // 
            disgustPicBx.BorderStyle = BorderStyle.FixedSingle;
            disgustPicBx.Image = Properties.Resources.disgust;
            disgustPicBx.Location = new Point(21, 118);
            disgustPicBx.Margin = new Padding(4, 5, 4, 5);
            disgustPicBx.Name = "disgustPicBx";
            disgustPicBx.Size = new Size(142, 167);
            disgustPicBx.TabIndex = 1;
            disgustPicBx.TabStop = false;
            // 
            // SelectLbl
            // 
            SelectLbl.AutoSize = true;
            SelectLbl.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectLbl.ForeColor = Color.Transparent;
            SelectLbl.Location = new Point(201, 65);
            SelectLbl.Margin = new Padding(4, 0, 4, 0);
            SelectLbl.Name = "SelectLbl";
            SelectLbl.Size = new Size(180, 23);
            SelectLbl.TabIndex = 0;
            SelectLbl.Text = "Select your mood";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 745);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1197, 258);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MoodForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1490, 1028);
            Controls.Add(dataGridView1);
            Controls.Add(MoodPnl);
            Controls.Add(MoodLbl);
            Location = new Point(215, -1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MoodForm";
            Text = "MoodForm";
            Load += MoodForm_Load;
            MoodPnl.ResumeLayout(false);
            MoodPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JoyPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)SadPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnxiPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)FearPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngerPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)disgustPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MoodLbl;
        private Label FeelLbl;
        private Panel MoodPnl;
        private PictureBox JoyPicBx;
        private PictureBox SadPicBx;
        private PictureBox AnxiPicBx;
        private PictureBox FearPicBx;
        private PictureBox AngerPicBx;
        private PictureBox disgustPicBx;
        private Label SelectLbl;
        private CheckBox DisCheckBx;
        private CheckBox JoyCheckBx;
        private CheckBox SadCheckBx;
        private CheckBox AnxiCheckBx;
        private CheckBox FearCheckBx;
        private CheckBox AngerCheckBx;
        private Button LogMoodBut;
        private Label HistoryLbl;
        private DateTimePicker MoodDate;
        private Button MoodHisBut;
        private DataGridView dataGridView1;
    }
}