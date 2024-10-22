namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AboutArtistForm
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
            label1 = new Label();
            ArtistNameLabel = new Label();
            pictureBox2 = new PictureBox();
            PlaylistsLabel = new Label();
            BackButton = new Button();
            ArtistAlbums = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1638, 89);
            label1.TabIndex = 6;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.BackColor = SystemColors.Desktop;
            ArtistNameLabel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArtistNameLabel.ForeColor = SystemColors.ButtonHighlight;
            ArtistNameLabel.Location = new Point(12, 110);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(815, 89);
            ArtistNameLabel.TabIndex = 8;
            ArtistNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.inger;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(815, 402);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // PlaylistsLabel
            // 
            PlaylistsLabel.BackColor = SystemColors.Desktop;
            PlaylistsLabel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaylistsLabel.ForeColor = SystemColors.ButtonHighlight;
            PlaylistsLabel.Location = new Point(844, 110);
            PlaylistsLabel.Name = "PlaylistsLabel";
            PlaylistsLabel.Size = new Size(806, 89);
            PlaylistsLabel.TabIndex = 10;
            PlaylistsLabel.Text = "Список плейлистов";
            PlaylistsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 128, 0);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(12, 644);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(815, 129);
            BackButton.TabIndex = 14;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ArtistAlbums
            // 
            ArtistAlbums.BackColor = SystemColors.InactiveCaptionText;
            ArtistAlbums.ForeColor = SystemColors.Window;
            ArtistAlbums.FormattingEnabled = true;
            ArtistAlbums.Location = new Point(846, 225);
            ArtistAlbums.Name = "ArtistAlbums";
            ArtistAlbums.Size = new Size(804, 548);
            ArtistAlbums.TabIndex = 15;
            ArtistAlbums.SelectedIndexChanged += ArtistAlbums_SelectedIndexChanged;
            // 
            // AboutArtistForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 785);
            Controls.Add(ArtistAlbums);
            Controls.Add(BackButton);
            Controls.Add(PlaylistsLabel);
            Controls.Add(pictureBox2);
            Controls.Add(ArtistNameLabel);
            Controls.Add(label1);
            Name = "AboutArtistForm";
            Text = "AboutArtistForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label ArtistNameLabel;
        private PictureBox pictureBox2;
        private Label PlaylistsLabel;
        private Button BackButton;
        private ListBox ArtistAlbums;
    }
}