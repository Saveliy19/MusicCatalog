namespace MusicCatalog.WinFormsUI.Forms
{
    partial class PlaylistCreatingForm
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
            panel1 = new Panel();
            PlaylistName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SubmitButton = new Button();
            BackButton = new Button();
            SearchResult = new ListBox();
            PlayListSongs = new ListBox();
            SearchSongBox = new TextBox();
            panel1.SuspendLayout();
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
            label1.TabIndex = 3;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(PlaylistName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(SearchResult);
            panel1.Controls.Add(PlayListSongs);
            panel1.Controls.Add(SearchSongBox);
            panel1.Location = new Point(12, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 780);
            panel1.TabIndex = 4;
            // 
            // PlaylistName
            // 
            PlaylistName.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlaylistName.Location = new Point(350, 14);
            PlaylistName.Multiline = true;
            PlaylistName.Name = "PlaylistName";
            PlaylistName.Size = new Size(414, 89);
            PlaylistName.TabIndex = 15;
            PlaylistName.TextChanged += PlaylistName_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 14);
            label3.Name = "label3";
            label3.Size = new Size(312, 89);
            label3.TabIndex = 14;
            label3.Text = "Название:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(849, 14);
            label2.Name = "label2";
            label2.Size = new Size(767, 89);
            label2.TabIndex = 5;
            label2.Text = "Выберите треки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(0, 192, 0);
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(22, 577);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(471, 183);
            SubmitButton.TabIndex = 13;
            SubmitButton.Text = "Create Playlist";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 128, 0);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(510, 577);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(254, 183);
            BackButton.TabIndex = 12;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SearchResult
            // 
            SearchResult.BackColor = SystemColors.WindowFrame;
            SearchResult.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchResult.FormattingEnabled = true;
            SearchResult.ItemHeight = 46;
            SearchResult.Location = new Point(849, 213);
            SearchResult.Name = "SearchResult";
            SearchResult.Size = new Size(767, 510);
            SearchResult.TabIndex = 3;
            SearchResult.SelectedIndexChanged += SearchResult_SelectedIndexChanged;
            // 
            // PlayListSongs
            // 
            PlayListSongs.BackColor = Color.Gray;
            PlayListSongs.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayListSongs.ForeColor = SystemColors.ActiveCaptionText;
            PlayListSongs.FormattingEnabled = true;
            PlayListSongs.ItemHeight = 46;
            PlayListSongs.Location = new Point(22, 116);
            PlayListSongs.Name = "PlayListSongs";
            PlayListSongs.Size = new Size(742, 418);
            PlayListSongs.TabIndex = 2;
            PlayListSongs.SelectedIndexChanged += PlayListSongs_SelectedIndexChanged;
            // 
            // SearchSongBox
            // 
            SearchSongBox.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchSongBox.Location = new Point(849, 116);
            SearchSongBox.Multiline = true;
            SearchSongBox.Name = "SearchSongBox";
            SearchSongBox.Size = new Size(767, 78);
            SearchSongBox.TabIndex = 0;
            SearchSongBox.TextChanged += SearchSongBox_TextChanged;
            // 
            // PlaylistCreatingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 906);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "PlaylistCreatingForm";
            Text = "PlaylistCreatingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListBox SearchResult;
        private ListBox PlayListSongs;
        private TextBox SearchSongBox;
        private Button BackButton;
        private Label label2;
        private Button SubmitButton;
        private Label label3;
        private TextBox PlaylistName;
    }
}