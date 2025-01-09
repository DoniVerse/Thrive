namespace thrive
{
    partial class MediaPlayer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            label2 = new Label();
            trackBar1 = new TrackBar();
            btnpause = new Button();
            btnstop = new Button();
            btnSart = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            timerplayback = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)musicPlayer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // musicPlayer
            // 
            musicPlayer.Enabled = true;
            musicPlayer.Location = new Point(0, 1);
            musicPlayer.Name = "musicPlayer";
            musicPlayer.OcxState = (AxHost.State)resources.GetObject("musicPlayer.OcxState");
            musicPlayer.Size = new Size(1027, 46);
            musicPlayer.TabIndex = 0;
            musicPlayer.Visible = false;
            musicPlayer.PlayStateChange += musicPlayer_PlayStateChange;
            musicPlayer.Enter += musicPlayer_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(btnpause);
            panel1.Controls.Add(btnstop);
            panel1.Controls.Add(btnSart);
            panel1.Location = new Point(0, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 140);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(713, 25);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 4;
            label2.Text = "Volume ";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(665, 57);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(289, 69);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnpause
            // 
            btnpause.BackColor = SystemColors.ActiveCaption;
            btnpause.Location = new Point(468, 59);
            btnpause.Name = "btnpause";
            btnpause.Size = new Size(134, 67);
            btnpause.TabIndex = 3;
            btnpause.Text = "pause";
            btnpause.UseVisualStyleBackColor = false;
            btnpause.Click += btnpause_Click;
            // 
            // btnstop
            // 
            btnstop.BackColor = SystemColors.ActiveCaption;
            btnstop.Location = new Point(245, 59);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(134, 67);
            btnstop.TabIndex = 2;
            btnstop.Text = "Stop";
            btnstop.UseVisualStyleBackColor = false;
            btnstop.Click += btnstop_Click;
            // 
            // btnSart
            // 
            btnSart.BackColor = SystemColors.ActiveCaption;
            btnSart.Location = new Point(30, 57);
            btnSart.Name = "btnSart";
            btnSart.Size = new Size(134, 67);
            btnSart.TabIndex = 1;
            btnSart.Text = "Start";
            btnSart.UseVisualStyleBackColor = false;
            btnSart.Click += btnSart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 22);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 4;
            label1.Text = "List of Sound tracks";
            // 
            // listBox1
            // 
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(0, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1013, 329);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // timerplayback
            // 
            timerplayback.Interval = 850;
            timerplayback.Tick += timerplayback_Tick;
            // 
            // MediaPlayer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 555);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(musicPlayer);
            Name = "MediaPlayer";
            Text = "Sound Track";
            Load += MediaPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)musicPlayer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private Panel panel1;
        private Button btnpause;
        private Button btnstop;
        private Button btnSart;
        private Label label1;
        private TrackBar trackBar1;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timerplayback;
        private Label label2;
    }
}