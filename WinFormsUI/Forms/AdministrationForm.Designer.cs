namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AdministrationForm
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
            MakeArtistButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            BackButton = new Button();
            MakeAlbumButton = new Button();
            MakePlButton = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MakeArtistButton
            // 
            MakeArtistButton.BackColor = Color.Black;
            MakeArtistButton.Cursor = Cursors.Hand;
            MakeArtistButton.FlatStyle = FlatStyle.Flat;
            MakeArtistButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MakeArtistButton.ForeColor = SystemColors.ButtonHighlight;
            MakeArtistButton.Location = new Point(18, 785);
            MakeArtistButton.Name = "MakeArtistButton";
            MakeArtistButton.Size = new Size(493, 58);
            MakeArtistButton.TabIndex = 0;
            MakeArtistButton.Text = "Создать музыканта";
            MakeArtistButton.UseVisualStyleBackColor = false;
            MakeArtistButton.Click += ArtistButton_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1638, 89);
            label1.TabIndex = 4;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(MakeAlbumButton);
            panel1.Controls.Add(MakePlButton);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(MakeArtistButton);
            panel1.Location = new Point(12, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 861);
            panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cat;
            pictureBox5.Location = new Point(530, 18);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(576, 825);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(1123, 785);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(493, 58);
            BackButton.TabIndex = 10;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MakeAlbumButton
            // 
            MakeAlbumButton.BackColor = Color.Black;
            MakeAlbumButton.Cursor = Cursors.Hand;
            MakeAlbumButton.FlatStyle = FlatStyle.Flat;
            MakeAlbumButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MakeAlbumButton.ForeColor = SystemColors.ButtonHighlight;
            MakeAlbumButton.Location = new Point(1123, 369);
            MakeAlbumButton.Name = "MakeAlbumButton";
            MakeAlbumButton.Size = new Size(493, 58);
            MakeAlbumButton.TabIndex = 9;
            MakeAlbumButton.Text = "Создать альбом";
            MakeAlbumButton.UseVisualStyleBackColor = false;
            // 
            // MakePlButton
            // 
            MakePlButton.BackColor = Color.Black;
            MakePlButton.Cursor = Cursors.Hand;
            MakePlButton.FlatStyle = FlatStyle.Flat;
            MakePlButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MakePlButton.ForeColor = SystemColors.ButtonHighlight;
            MakePlButton.Location = new Point(18, 369);
            MakePlButton.Name = "MakePlButton";
            MakePlButton.Size = new Size(493, 58);
            MakePlButton.TabIndex = 8;
            MakePlButton.Text = "Создать плейлист";
            MakePlButton.UseVisualStyleBackColor = false;
            MakePlButton.Click += MakePlButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.hb2;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1123, 450);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(493, 329);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.vinyl_record;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(18, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(493, 345);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.inger;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 450);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(493, 329);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.vinyl;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1123, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AdministrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 984);
            Controls.Add(panel1);
            Controls.Add(label1);
            MaximumSize = new Size(1688, 1055);
            Name = "AdministrationForm";
            Text = "AdministrationForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button MakeArtistButton;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button BackButton;
        private Button MakeAlbumButton;
        private Button MakePlButton;
        private PictureBox pictureBox5;
    }
}