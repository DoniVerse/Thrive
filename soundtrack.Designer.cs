namespace thrive
{
    partial class SoundTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundTrack));
            Soundtlable = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            RainLbl = new LinkLabel();
            NatureLbl = new LinkLabel();
            WhiteLbl = new LinkLabel();
            NFLbl = new LinkLabel();
            CozyLbl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Soundtlable
            // 
            Soundtlable.AutoSize = true;
            Soundtlable.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Soundtlable.ForeColor = SystemColors.ControlDarkDark;
            Soundtlable.Location = new Point(124, 24);
            Soundtlable.Margin = new Padding(2, 0, 2, 0);
            Soundtlable.Name = "Soundtlable";
            Soundtlable.Size = new Size(190, 36);
            Soundtlable.TabIndex = 0;
            Soundtlable.Text = "Sound Track";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 92);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 170);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(522, 92);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 170);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Nf1;
            pictureBox5.Location = new Point(81, 335);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(134, 170);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(314, 335);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(134, 170);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rainfall;
            pictureBox1.Location = new Point(81, 92);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 170);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RainLbl
            // 
            RainLbl.AutoSize = true;
            RainLbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RainLbl.LinkColor = Color.Black;
            RainLbl.Location = new Point(115, 291);
            RainLbl.Name = "RainLbl";
            RainLbl.Size = new Size(63, 17);
            RainLbl.TabIndex = 13;
            RainLbl.TabStop = true;
            RainLbl.Text = "Rain fall";
            RainLbl.LinkClicked += RainLbl_LinkClicked;
            // 
            // NatureLbl
            // 
            NatureLbl.AutoSize = true;
            NatureLbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NatureLbl.LinkColor = Color.Black;
            NatureLbl.Location = new Point(360, 289);
            NatureLbl.Name = "NatureLbl";
            NatureLbl.Size = new Size(53, 17);
            NatureLbl.TabIndex = 14;
            NatureLbl.TabStop = true;
            NatureLbl.Text = "Nature";
            NatureLbl.LinkClicked += NatureLbl_LinkClicked;
            // 
            // WhiteLbl
            // 
            WhiteLbl.AutoSize = true;
            WhiteLbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WhiteLbl.LinkColor = Color.Black;
            WhiteLbl.Location = new Point(547, 289);
            WhiteLbl.Name = "WhiteLbl";
            WhiteLbl.Size = new Size(86, 17);
            WhiteLbl.TabIndex = 16;
            WhiteLbl.TabStop = true;
            WhiteLbl.Text = "White Noise";
            WhiteLbl.LinkClicked += linkLabel1_LinkClicked;
            // 
            // NFLbl
            // 
            NFLbl.AutoSize = true;
            NFLbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NFLbl.LinkColor = Color.Black;
            NFLbl.Location = new Point(124, 520);
            NFLbl.Name = "NFLbl";
            NFLbl.Size = new Size(26, 17);
            NFLbl.TabIndex = 17;
            NFLbl.TabStop = true;
            NFLbl.Text = "NF";
            NFLbl.LinkClicked += NFLbl_LinkClicked;
            // 
            // CozyLbl
            // 
            CozyLbl.AutoSize = true;
            CozyLbl.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CozyLbl.LinkColor = Color.Black;
            CozyLbl.Location = new Point(335, 520);
            CozyLbl.Name = "CozyLbl";
            CozyLbl.Size = new Size(78, 17);
            CozyLbl.TabIndex = 18;
            CozyLbl.TabStop = true;
            CozyLbl.Text = "Cozy Night";
            CozyLbl.LinkClicked += CozyLbl_LinkClicked;
            // 
            // SoundTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(862, 595);
            Controls.Add(CozyLbl);
            Controls.Add(NFLbl);
            Controls.Add(WhiteLbl);
            Controls.Add(NatureLbl);
            Controls.Add(RainLbl);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Soundtlable);
            Margin = new Padding(2);
            Name = "SoundTrack";
            Text = "soundtrack";
            Load += SoundTrack_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Soundtlable;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private LinkLabel RainLbl;
        private LinkLabel NatureLbl;
        private LinkLabel WhiteLbl;
        private LinkLabel NFLbl;
        private LinkLabel CozyLbl;
    }
}