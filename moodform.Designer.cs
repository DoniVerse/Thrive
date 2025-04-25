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
            MoodLbl.Location = new Point(313, 9);
            MoodLbl.Name = "MoodLbl";
            MoodLbl.Size = new Size(145, 24);
            MoodLbl.TabIndex = 0;
            MoodLbl.Text = "MoodTracker";
            // 
            // FeelLbl
            // 
            FeelLbl.AutoSize = true;
            FeelLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeelLbl.ForeColor = Color.Transparent;
            FeelLbl.Location = new Point(214, 7);
            FeelLbl.Name = "FeelLbl";
            FeelLbl.Size = new Size(205, 17);
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
            MoodPnl.Location = new Point(36, 34);
            MoodPnl.Name = "MoodPnl";
            MoodPnl.Size = new Size(792, 363);
            MoodPnl.TabIndex = 2;
            MoodPnl.Paint += MoodPnl_Paint;
            // 
            // MoodHisBut
            // 
            MoodHisBut.BackColor = SystemColors.Highlight;
            MoodHisBut.FlatStyle = FlatStyle.Flat;
            MoodHisBut.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoodHisBut.ForeColor = Color.Transparent;
            MoodHisBut.Location = new Point(402, 287);
            MoodHisBut.Name = "MoodHisBut";
            MoodHisBut.RightToLeft = RightToLeft.No;
            MoodHisBut.Size = new Size(124, 28);
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
            HistoryLbl.Location = new Point(141, 292);
            HistoryLbl.Name = "HistoryLbl";
            HistoryLbl.Size = new Size(252, 18);
            HistoryLbl.TabIndex = 15;
            HistoryLbl.Text = "Wanna see your mood history?";
            // 
            // MoodDate
            // 
            MoodDate.CalendarForeColor = SystemColors.ActiveCaption;
            MoodDate.Location = new Point(3, 241);
            MoodDate.Name = "MoodDate";
            MoodDate.Size = new Size(200, 23);
            MoodDate.TabIndex = 14;
            // 
            // LogMoodBut
            // 
            LogMoodBut.BackColor = SystemColors.Highlight;
            LogMoodBut.FlatStyle = FlatStyle.Flat;
            LogMoodBut.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogMoodBut.ForeColor = Color.Transparent;
            LogMoodBut.Location = new Point(257, 238);
            LogMoodBut.Name = "LogMoodBut";
            LogMoodBut.Size = new Size(87, 28);
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
            JoyCheckBx.Location = new Point(141, 197);
            JoyCheckBx.Name = "JoyCheckBx";
            JoyCheckBx.Size = new Size(47, 18);
            JoyCheckBx.TabIndex = 12;
            JoyCheckBx.Text = "Joy";
            JoyCheckBx.UseVisualStyleBackColor = true;
            // 
            // SadCheckBx
            // 
            SadCheckBx.AutoSize = true;
            SadCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SadCheckBx.ForeColor = Color.Transparent;
            SadCheckBx.Location = new Point(257, 197);
            SadCheckBx.Name = "SadCheckBx";
            SadCheckBx.Size = new Size(49, 18);
            SadCheckBx.TabIndex = 11;
            SadCheckBx.Text = "Sad";
            SadCheckBx.UseVisualStyleBackColor = true;
            // 
            // AnxiCheckBx
            // 
            AnxiCheckBx.AutoSize = true;
            AnxiCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnxiCheckBx.ForeColor = Color.Transparent;
            AnxiCheckBx.Location = new Point(372, 197);
            AnxiCheckBx.Name = "AnxiCheckBx";
            AnxiCheckBx.Size = new Size(69, 18);
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
            FearCheckBx.Location = new Point(490, 203);
            FearCheckBx.Name = "FearCheckBx";
            FearCheckBx.Size = new Size(52, 18);
            FearCheckBx.TabIndex = 9;
            FearCheckBx.Text = "Fear";
            FearCheckBx.UseVisualStyleBackColor = true;
            // 
            // AngerCheckBx
            // 
            AngerCheckBx.AutoSize = true;
            AngerCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AngerCheckBx.ForeColor = Color.Transparent;
            AngerCheckBx.Location = new Point(615, 197);
            AngerCheckBx.Name = "AngerCheckBx";
            AngerCheckBx.Size = new Size(62, 18);
            AngerCheckBx.TabIndex = 8;
            AngerCheckBx.Text = "Anger";
            AngerCheckBx.UseVisualStyleBackColor = true;
            // 
            // DisCheckBx
            // 
            DisCheckBx.AutoSize = true;
            DisCheckBx.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisCheckBx.ForeColor = Color.Transparent;
            DisCheckBx.Location = new Point(15, 197);
            DisCheckBx.Name = "DisCheckBx";
            DisCheckBx.Size = new Size(71, 18);
            DisCheckBx.TabIndex = 7;
            DisCheckBx.Text = "Disgust";
            DisCheckBx.UseVisualStyleBackColor = true;
            // 
            // JoyPicBx
            // 
            JoyPicBx.BorderStyle = BorderStyle.FixedSingle;
            JoyPicBx.Image = (Image)resources.GetObject("JoyPicBx.Image");
            JoyPicBx.Location = new Point(141, 71);
            JoyPicBx.Name = "JoyPicBx";
            JoyPicBx.Size = new Size(100, 101);
            JoyPicBx.TabIndex = 6;
            JoyPicBx.TabStop = false;
            // 
            // SadPicBx
            // 
            SadPicBx.BorderStyle = BorderStyle.FixedSingle;
            SadPicBx.Image = (Image)resources.GetObject("SadPicBx.Image");
            SadPicBx.Location = new Point(257, 71);
            SadPicBx.Name = "SadPicBx";
            SadPicBx.Size = new Size(100, 101);
            SadPicBx.TabIndex = 5;
            SadPicBx.TabStop = false;
            // 
            // AnxiPicBx
            // 
            AnxiPicBx.BorderStyle = BorderStyle.FixedSingle;
            AnxiPicBx.Image = (Image)resources.GetObject("AnxiPicBx.Image");
            AnxiPicBx.Location = new Point(372, 71);
            AnxiPicBx.Name = "AnxiPicBx";
            AnxiPicBx.Size = new Size(100, 101);
            AnxiPicBx.TabIndex = 4;
            AnxiPicBx.TabStop = false;
            AnxiPicBx.Click += AnxiPicBx_Click;
            // 
            // FearPicBx
            // 
            FearPicBx.BorderStyle = BorderStyle.FixedSingle;
            FearPicBx.Image = (Image)resources.GetObject("FearPicBx.Image");
            FearPicBx.Location = new Point(490, 73);
            FearPicBx.Name = "FearPicBx";
            FearPicBx.Size = new Size(100, 99);
            FearPicBx.TabIndex = 3;
            FearPicBx.TabStop = false;
            // 
            // AngerPicBx
            // 
            AngerPicBx.BorderStyle = BorderStyle.FixedSingle;
            AngerPicBx.Image = (Image)resources.GetObject("AngerPicBx.Image");
            AngerPicBx.Location = new Point(615, 73);
            AngerPicBx.Name = "AngerPicBx";
            AngerPicBx.Size = new Size(100, 99);
            AngerPicBx.TabIndex = 2;
            AngerPicBx.TabStop = false;
            // 
            // disgustPicBx
            // 
            disgustPicBx.BorderStyle = BorderStyle.FixedSingle;
            disgustPicBx.Image = Properties.Resources.disgust;
            disgustPicBx.Location = new Point(15, 71);
            disgustPicBx.Name = "disgustPicBx";
            disgustPicBx.Size = new Size(100, 101);
            disgustPicBx.TabIndex = 1;
            disgustPicBx.TabStop = false;
            // 
            // SelectLbl
            // 
            SelectLbl.AutoSize = true;
            SelectLbl.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectLbl.ForeColor = Color.Transparent;
            SelectLbl.Location = new Point(141, 39);
            SelectLbl.Name = "SelectLbl";
            SelectLbl.Size = new Size(120, 15);
            SelectLbl.TabIndex = 0;
            SelectLbl.Text = "Select your mood";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 447);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(838, 155);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(959, 611);
            Controls.Add(dataGridView1);
            Controls.Add(MoodPnl);
            Controls.Add(MoodLbl);
            Location = new Point(215, -1);
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