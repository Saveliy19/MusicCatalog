namespace MusicCatalog.WinFormsUI.Forms
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            SearchButton = new Button();
            SearchBox = new TextBox();
            label1 = new Label();
            Genre = new RadioButton();
            Artists = new RadioButton();
            Song = new RadioButton();
            Albums = new RadioButton();
            PlayLists = new RadioButton();
            SearchResult = new ListBox();
            SearchButtonsBox = new GroupBox();
            AdminButton = new Button();
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            SearchResultLabel = new Label();
            SearchButtonsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = Properties.Resources.adidas;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.ForeColor = SystemColors.Window;
            SearchButton.Location = new Point(653, 109);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(114, 96);
            SearchButton.TabIndex = 0;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = SystemColors.Window;
            SearchBox.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(12, 109);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(635, 96);
            SearchBox.TabIndex = 1;
            SearchBox.TextAlign = HorizontalAlignment.Center;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1638, 89);
            label1.TabIndex = 2;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Genre
            // 
            Genre.Appearance = Appearance.Button;
            Genre.BackColor = Color.Black;
            Genre.BackgroundImageLayout = ImageLayout.Stretch;
            Genre.CheckAlign = ContentAlignment.MiddleCenter;
            Genre.Checked = true;
            Genre.Cursor = Cursors.Hand;
            Genre.FlatAppearance.BorderColor = Color.White;
            Genre.FlatAppearance.BorderSize = 6;
            Genre.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Genre.FlatAppearance.MouseOverBackColor = Color.Black;
            Genre.FlatStyle = FlatStyle.Flat;
            Genre.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre.ForeColor = SystemColors.ButtonHighlight;
            Genre.Location = new Point(6, 9);
            Genre.Name = "Genre";
            Genre.Size = new Size(285, 83);
            Genre.TabIndex = 5;
            Genre.TabStop = true;
            Genre.Text = "Трек по жанру";
            Genre.TextAlign = ContentAlignment.MiddleCenter;
            Genre.UseVisualStyleBackColor = false;
            Genre.CheckedChanged += All_CheckedChanged;
            // 
            // Artists
            // 
            Artists.Appearance = Appearance.Button;
            Artists.BackColor = Color.Black;
            Artists.Cursor = Cursors.Hand;
            Artists.FlatAppearance.BorderColor = Color.White;
            Artists.FlatAppearance.BorderSize = 6;
            Artists.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Artists.FlatStyle = FlatStyle.Flat;
            Artists.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Artists.ForeColor = SystemColors.ButtonHighlight;
            Artists.Location = new Point(6, 365);
            Artists.Name = "Artists";
            Artists.Size = new Size(283, 83);
            Artists.TabIndex = 6;
            Artists.Text = "Исполнители";
            Artists.TextAlign = ContentAlignment.MiddleCenter;
            Artists.UseMnemonic = false;
            Artists.UseVisualStyleBackColor = false;
            Artists.CheckedChanged += Artists_CheckedChanged;
            // 
            // Song
            // 
            Song.Appearance = Appearance.Button;
            Song.BackColor = Color.Black;
            Song.Cursor = Cursors.Hand;
            Song.FlatAppearance.BorderColor = Color.White;
            Song.FlatAppearance.BorderSize = 6;
            Song.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Song.FlatStyle = FlatStyle.Flat;
            Song.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Song.ForeColor = SystemColors.ButtonHighlight;
            Song.Location = new Point(6, 98);
            Song.Name = "Song";
            Song.Size = new Size(285, 83);
            Song.TabIndex = 7;
            Song.Text = "Трек по названию";
            Song.TextAlign = ContentAlignment.MiddleCenter;
            Song.UseVisualStyleBackColor = false;
            Song.CheckedChanged += Song_CheckedChanged;
            // 
            // Albums
            // 
            Albums.Appearance = Appearance.Button;
            Albums.BackColor = Color.Black;
            Albums.Cursor = Cursors.Hand;
            Albums.FlatAppearance.BorderColor = Color.White;
            Albums.FlatAppearance.BorderSize = 6;
            Albums.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            Albums.FlatStyle = FlatStyle.Flat;
            Albums.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Albums.ForeColor = SystemColors.ButtonHighlight;
            Albums.Location = new Point(6, 187);
            Albums.Name = "Albums";
            Albums.Size = new Size(285, 83);
            Albums.TabIndex = 8;
            Albums.TabStop = true;
            Albums.Text = "Альбомы";
            Albums.TextAlign = ContentAlignment.MiddleCenter;
            Albums.UseVisualStyleBackColor = false;
            Albums.CheckedChanged += Albums_CheckedChanged;
            // 
            // PlayLists
            // 
            PlayLists.Appearance = Appearance.Button;
            PlayLists.BackColor = Color.Black;
            PlayLists.Cursor = Cursors.Hand;
            PlayLists.FlatAppearance.BorderColor = Color.White;
            PlayLists.FlatAppearance.BorderSize = 6;
            PlayLists.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            PlayLists.FlatStyle = FlatStyle.Flat;
            PlayLists.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayLists.ForeColor = SystemColors.ButtonHighlight;
            PlayLists.Location = new Point(6, 276);
            PlayLists.Name = "PlayLists";
            PlayLists.Size = new Size(283, 83);
            PlayLists.TabIndex = 9;
            PlayLists.TabStop = true;
            PlayLists.Text = "Плейлисты";
            PlayLists.TextAlign = ContentAlignment.MiddleCenter;
            PlayLists.UseVisualStyleBackColor = false;
            PlayLists.CheckedChanged += PlayLists_CheckedChanged;
            // 
            // SearchResult
            // 
            SearchResult.Anchor = AnchorStyles.Top;
            SearchResult.BackColor = Color.Black;
            SearchResult.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchResult.ForeColor = SystemColors.HighlightText;
            SearchResult.FormattingEnabled = true;
            SearchResult.ItemHeight = 46;
            SearchResult.Location = new Point(779, 220);
            SearchResult.Name = "SearchResult";
            SearchResult.Size = new Size(871, 740);
            SearchResult.TabIndex = 0;
            SearchResult.SelectedIndexChanged += SearchResult_SelectedIndexChanged;
            // 
            // SearchButtonsBox
            // 
            SearchButtonsBox.BackColor = Color.MistyRose;
            SearchButtonsBox.Controls.Add(Genre);
            SearchButtonsBox.Controls.Add(Song);
            SearchButtonsBox.Controls.Add(Albums);
            SearchButtonsBox.Controls.Add(Artists);
            SearchButtonsBox.Controls.Add(PlayLists);
            SearchButtonsBox.Location = new Point(12, 211);
            SearchButtonsBox.Name = "SearchButtonsBox";
            SearchButtonsBox.Size = new Size(298, 458);
            SearchButtonsBox.TabIndex = 11;
            SearchButtonsBox.TabStop = false;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.Black;
            AdminButton.Cursor = Cursors.Hand;
            AdminButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminButton.ForeColor = SystemColors.ButtonHighlight;
            AdminButton.Location = new Point(12, 675);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(755, 88);
            AdminButton.TabIndex = 12;
            AdminButton.Text = "Администрирование";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hb;
            pictureBox1.Location = new Point(316, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Properties.Resources.hb2;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ButtonHighlight;
            exitButton.Location = new Point(12, 769);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(755, 203);
            exitButton.TabIndex = 14;
            exitButton.Text = "Выход";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // SearchResultLabel
            // 
            SearchResultLabel.BackColor = Color.Black;
            SearchResultLabel.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchResultLabel.ForeColor = SystemColors.ButtonHighlight;
            SearchResultLabel.Location = new Point(779, 109);
            SearchResultLabel.Name = "SearchResultLabel";
            SearchResultLabel.Size = new Size(871, 95);
            SearchResultLabel.TabIndex = 1;
            SearchResultLabel.Text = "Результаты поиска";
            SearchResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1662, 984);
            Controls.Add(SearchResultLabel);
            Controls.Add(exitButton);
            Controls.Add(SearchResult);
            Controls.Add(pictureBox1);
            Controls.Add(AdminButton);
            Controls.Add(SearchButtonsBox);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1689, 1056);
            Name = "StartForm";
            Text = "HardBass";
            SearchButtonsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchBox;
        private Label label1;
        private RadioButton Genre;
        private RadioButton Artists;
        private RadioButton Song;
        private RadioButton Albums;
        private RadioButton PlayLists;
        private GroupBox SearchButtonsBox;
        private ListBox SearchResult;
        private Button AdminButton;
        private PictureBox pictureBox1;
        private Button exitButton;
        private Label SearchResultLabel;
    }
}
