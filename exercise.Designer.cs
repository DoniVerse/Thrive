namespace thrive
{
    partial class Exercise
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
            exlable = new Label();
            YogaPicBx = new PictureBox();
            TaiPicBx = new PictureBox();
            MediPicBx = new PictureBox();
            PilatesPicBx = new PictureBox();
            BreathPicBx = new PictureBox();
            YogaLbl = new Label();
            YogaWatchBut = new Button();
            MediLbl = new Label();
            TaiLbl = new Label();
            pilatesLbl = new Label();
            BreathLbl = new Label();
            BreathBut = new Button();
            PilatesBut = new Button();
            MediBut = new Button();
            TaiBut = new Button();
            ((System.ComponentModel.ISupportInitialize)YogaPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TaiPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MediPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PilatesPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BreathPicBx).BeginInit();
            SuspendLayout();
            // 
            // exlable
            // 
            exlable.AutoSize = true;
            exlable.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exlable.ForeColor = SystemColors.Highlight;
            exlable.Location = new Point(302, 25);
            exlable.Margin = new Padding(2, 0, 2, 0);
            exlable.Name = "exlable";
            exlable.Size = new Size(164, 24);
            exlable.TabIndex = 0;
            exlable.Text = "Exercise Board";
            exlable.Click += label1_Click;
            // 
            // YogaPicBx
            // 
            YogaPicBx.BorderStyle = BorderStyle.Fixed3D;
            YogaPicBx.Image = Properties.Resources.yoga;
            YogaPicBx.Location = new Point(71, 122);
            YogaPicBx.Name = "YogaPicBx";
            YogaPicBx.Size = new Size(243, 162);
            YogaPicBx.TabIndex = 1;
            YogaPicBx.TabStop = false;
            // 
            // TaiPicBx
            // 
            TaiPicBx.BorderStyle = BorderStyle.Fixed3D;
            TaiPicBx.Image = Properties.Resources.Tia;
            TaiPicBx.Location = new Point(485, 415);
            TaiPicBx.Name = "TaiPicBx";
            TaiPicBx.Size = new Size(243, 162);
            TaiPicBx.TabIndex = 2;
            TaiPicBx.TabStop = false;
            // 
            // MediPicBx
            // 
            MediPicBx.BorderStyle = BorderStyle.Fixed3D;
            MediPicBx.Image = Properties.Resources.meditation;
            MediPicBx.Location = new Point(71, 415);
            MediPicBx.Name = "MediPicBx";
            MediPicBx.Size = new Size(243, 162);
            MediPicBx.TabIndex = 3;
            MediPicBx.TabStop = false;
            // 
            // PilatesPicBx
            // 
            PilatesPicBx.BorderStyle = BorderStyle.Fixed3D;
            PilatesPicBx.Image = Properties.Resources.pilates;
            PilatesPicBx.Location = new Point(767, 122);
            PilatesPicBx.Name = "PilatesPicBx";
            PilatesPicBx.Size = new Size(243, 162);
            PilatesPicBx.TabIndex = 4;
            PilatesPicBx.TabStop = false;
            // 
            // BreathPicBx
            // 
            BreathPicBx.BorderStyle = BorderStyle.Fixed3D;
            BreathPicBx.Image = Properties.Resources.breath;
            BreathPicBx.Location = new Point(440, 122);
            BreathPicBx.Name = "BreathPicBx";
            BreathPicBx.Size = new Size(243, 162);
            BreathPicBx.TabIndex = 5;
            BreathPicBx.TabStop = false;
            // 
            // YogaLbl
            // 
            YogaLbl.AutoSize = true;
            YogaLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YogaLbl.ForeColor = SystemColors.Highlight;
            YogaLbl.Location = new Point(169, 314);
            YogaLbl.Name = "YogaLbl";
            YogaLbl.Size = new Size(44, 17);
            YogaLbl.TabIndex = 6;
            YogaLbl.Text = "Yoga";
            // 
            // YogaWatchBut
            // 
            YogaWatchBut.BackColor = SystemColors.Highlight;
            YogaWatchBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YogaWatchBut.ForeColor = Color.Transparent;
            YogaWatchBut.Location = new Point(151, 354);
            YogaWatchBut.Name = "YogaWatchBut";
            YogaWatchBut.Size = new Size(102, 35);
            YogaWatchBut.TabIndex = 7;
            YogaWatchBut.Text = "Watch now";
            YogaWatchBut.UseVisualStyleBackColor = false;
            YogaWatchBut.Click += YogaWatchBut_Click;
            // 
            // MediLbl
            // 
            MediLbl.AutoSize = true;
            MediLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MediLbl.ForeColor = SystemColors.Highlight;
            MediLbl.Location = new Point(143, 599);
            MediLbl.Name = "MediLbl";
            MediLbl.Size = new Size(83, 17);
            MediLbl.TabIndex = 8;
            MediLbl.Text = "Meditation";
            // 
            // TaiLbl
            // 
            TaiLbl.AutoSize = true;
            TaiLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaiLbl.ForeColor = SystemColors.Highlight;
            TaiLbl.Location = new Point(582, 599);
            TaiLbl.Name = "TaiLbl";
            TaiLbl.Size = new Size(58, 17);
            TaiLbl.TabIndex = 9;
            TaiLbl.Text = "Tai Chi";
            // 
            // pilatesLbl
            // 
            pilatesLbl.AutoSize = true;
            pilatesLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilatesLbl.ForeColor = SystemColors.Highlight;
            pilatesLbl.Location = new Point(868, 314);
            pilatesLbl.Name = "pilatesLbl";
            pilatesLbl.Size = new Size(57, 17);
            pilatesLbl.TabIndex = 10;
            pilatesLbl.Text = "Pilates";
            // 
            // BreathLbl
            // 
            BreathLbl.AutoSize = true;
            BreathLbl.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreathLbl.ForeColor = SystemColors.Highlight;
            BreathLbl.Location = new Point(503, 314);
            BreathLbl.Name = "BreathLbl";
            BreathLbl.Size = new Size(147, 17);
            BreathLbl.TabIndex = 11;
            BreathLbl.Text = "Breathing excerise";
            // 
            // BreathBut
            // 
            BreathBut.BackColor = SystemColors.Highlight;
            BreathBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreathBut.ForeColor = Color.Transparent;
            BreathBut.Location = new Point(524, 354);
            BreathBut.Name = "BreathBut";
            BreathBut.Size = new Size(102, 35);
            BreathBut.TabIndex = 12;
            BreathBut.Text = "Watch now";
            BreathBut.UseVisualStyleBackColor = false;
            BreathBut.Click += BreathBut_Click;
            // 
            // PilatesBut
            // 
            PilatesBut.BackColor = SystemColors.Highlight;
            PilatesBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PilatesBut.ForeColor = Color.Transparent;
            PilatesBut.Location = new Point(853, 357);
            PilatesBut.Name = "PilatesBut";
            PilatesBut.Size = new Size(102, 35);
            PilatesBut.TabIndex = 13;
            PilatesBut.Text = "Watch now";
            PilatesBut.UseVisualStyleBackColor = false;
            PilatesBut.Click += PilatesBut_Click;
            // 
            // MediBut
            // 
            MediBut.BackColor = SystemColors.Highlight;
            MediBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MediBut.ForeColor = Color.Transparent;
            MediBut.Location = new Point(143, 644);
            MediBut.Name = "MediBut";
            MediBut.Size = new Size(102, 35);
            MediBut.TabIndex = 14;
            MediBut.Text = "Watch now";
            MediBut.UseVisualStyleBackColor = false;
            MediBut.Click += button3_Click;
            // 
            // TaiBut
            // 
            TaiBut.BackColor = SystemColors.Highlight;
            TaiBut.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaiBut.ForeColor = Color.Transparent;
            TaiBut.Location = new Point(567, 644);
            TaiBut.Name = "TaiBut";
            TaiBut.Size = new Size(102, 35);
            TaiBut.TabIndex = 15;
            TaiBut.Text = "Watch now";
            TaiBut.UseVisualStyleBackColor = false;
            TaiBut.Click += TaiBut_Click;
            // 
            // Exercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 749);
            Controls.Add(TaiBut);
            Controls.Add(MediBut);
            Controls.Add(PilatesBut);
            Controls.Add(BreathBut);
            Controls.Add(BreathLbl);
            Controls.Add(pilatesLbl);
            Controls.Add(TaiLbl);
            Controls.Add(MediLbl);
            Controls.Add(YogaWatchBut);
            Controls.Add(YogaLbl);
            Controls.Add(BreathPicBx);
            Controls.Add(PilatesPicBx);
            Controls.Add(MediPicBx);
            Controls.Add(TaiPicBx);
            Controls.Add(YogaPicBx);
            Controls.Add(exlable);
            Margin = new Padding(2);
            Name = "Exercise";
            Text = "exercise";
            Load += Exercise_Load;
            ((System.ComponentModel.ISupportInitialize)YogaPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)TaiPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)MediPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)PilatesPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)BreathPicBx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exlable;
        private PictureBox YogaPicBx;
        private PictureBox TaiPicBx;
        private PictureBox MediPicBx;
        private PictureBox PilatesPicBx;
        private PictureBox BreathPicBx;
        private Label YogaLbl;
        private Button YogaWatchBut;
        private Label MediLbl;
        private Label TaiLbl;
        private Label pilatesLbl;
        private Label BreathLbl;
        private Button BreathBut;
        private Button PilatesBut;
        private Button MediBut;
        private Button TaiBut;
    }
}