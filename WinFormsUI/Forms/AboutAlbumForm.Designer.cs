namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AboutAlbumForm
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
            AlbumNameLabel = new Label();
            ArtistNameLabel = new Label();
            TrackListLabel = new Label();
            TrackListBox = new ListBox();
            BackButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.TabIndex = 5;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlbumNameLabel
            // 
            AlbumNameLabel.BackColor = SystemColors.Desktop;
            AlbumNameLabel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlbumNameLabel.ForeColor = SystemColors.ButtonHighlight;
            AlbumNameLabel.Location = new Point(12, 116);
            AlbumNameLabel.Name = "AlbumNameLabel";
            AlbumNameLabel.Size = new Size(815, 89);
            AlbumNameLabel.TabIndex = 6;
            AlbumNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.BackColor = SystemColors.Desktop;
            ArtistNameLabel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArtistNameLabel.ForeColor = SystemColors.ButtonHighlight;
            ArtistNameLabel.Location = new Point(12, 216);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(815, 89);
            ArtistNameLabel.TabIndex = 7;
            ArtistNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrackListLabel
            // 
            TrackListLabel.BackColor = SystemColors.Desktop;
            TrackListLabel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrackListLabel.ForeColor = SystemColors.ButtonHighlight;
            TrackListLabel.Location = new Point(838, 116);
            TrackListLabel.Name = "TrackListLabel";
            TrackListLabel.Size = new Size(810, 89);
            TrackListLabel.TabIndex = 8;
            TrackListLabel.Text = "TrackList";
            TrackListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrackListBox
            // 
            TrackListBox.BackColor = SystemColors.InactiveCaptionText;
            TrackListBox.ForeColor = SystemColors.Window;
            TrackListBox.FormattingEnabled = true;
            TrackListBox.Location = new Point(838, 219);
            TrackListBox.Name = "TrackListBox";
            TrackListBox.Size = new Size(810, 452);
            TrackListBox.TabIndex = 9;
            
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 128, 0);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(528, 324);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(299, 345);
            BackButton.TabIndex = 13;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.vinyl;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 326);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AboutAlbumForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 678);
            Controls.Add(pictureBox1);
            Controls.Add(BackButton);
            Controls.Add(TrackListBox);
            Controls.Add(TrackListLabel);
            Controls.Add(ArtistNameLabel);
            Controls.Add(AlbumNameLabel);
            Controls.Add(label1);
            Name = "AboutAlbumForm";
            Text = "AboutAlbumForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label AlbumNameLabel;
        private Label ArtistNameLabel;
        private Label TrackListLabel;
        private ListBox TrackListBox;
        private Button BackButton;
        private PictureBox pictureBox1;
    }
}