namespace thrive
{
    partial class WatchFr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchFr));
            WatchMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            WatchFrBut = new Button();
            ((System.ComponentModel.ISupportInitialize)WatchMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // WatchMediaPlayer
            // 
            WatchMediaPlayer.Enabled = true;
            WatchMediaPlayer.Location = new Point(148, 12);
            WatchMediaPlayer.Name = "WatchMediaPlayer";
            WatchMediaPlayer.OcxState = (AxHost.State)resources.GetObject("WatchMediaPlayer.OcxState");
            WatchMediaPlayer.Size = new Size(640, 414);
            WatchMediaPlayer.TabIndex = 0;
            WatchMediaPlayer.Enter += WatchMediaPlayer_Enter;
            // 
            // WatchFrBut
            // 
            WatchFrBut.BackColor = SystemColors.Highlight;
            WatchFrBut.FlatStyle = FlatStyle.Flat;
            WatchFrBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WatchFrBut.ForeColor = Color.Transparent;
            WatchFrBut.Location = new Point(21, 26);
            WatchFrBut.Name = "WatchFrBut";
            WatchFrBut.Size = new Size(75, 32);
            WatchFrBut.TabIndex = 1;
            WatchFrBut.Text = "Back";
            WatchFrBut.UseVisualStyleBackColor = false;
            WatchFrBut.Click += WatchFrBut_Click;
            // 
            // WatchFr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(WatchFrBut);
            Controls.Add(WatchMediaPlayer);
            Name = "WatchFr";
            Text = "WatchFr";
            Load += WatchFr_Load;
            ((System.ComponentModel.ISupportInitialize)WatchMediaPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WatchMediaPlayer;
        private Button WatchFrBut;
    }
}