namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AlbumCreatingForm
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
            Seconds = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            Minutes = new NumericUpDown();
            AddSongButton = new Button();
            SongName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ArtistBox = new ComboBox();
            BackButton = new Button();
            SubmitButton = new Button();
            label3 = new Label();
            label2 = new Label();
            AlbumName = new TextBox();
            SongListBox = new ListBox();
            label8 = new Label();
            GenreBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minutes).BeginInit();
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
            label1.TabIndex = 4;
            label1.Text = "Музыкальный каталог HardBass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(GenreBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Seconds);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Minutes);
            panel1.Controls.Add(AddSongButton);
            panel1.Controls.Add(SongName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ArtistBox);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AlbumName);
            panel1.Controls.Add(SongListBox);
            panel1.Location = new Point(12, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 754);
            panel1.TabIndex = 5;
            // 
            // Seconds
            // 
            Seconds.Location = new Point(1153, 476);
            Seconds.Name = "Seconds";
            Seconds.Size = new Size(124, 39);
            Seconds.TabIndex = 24;
            
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveBorder;
            label7.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(912, 476);
            label7.Name = "label7";
            label7.Size = new Size(228, 58);
            label7.TabIndex = 23;
            label7.Text = "Секунды";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(912, 394);
            label6.Name = "label6";
            label6.Size = new Size(228, 58);
            label6.TabIndex = 22;
            label6.Text = "Минуты";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Minutes
            // 
            Minutes.Location = new Point(1153, 394);
            Minutes.Name = "Minutes";
            Minutes.Size = new Size(124, 39);
            Minutes.TabIndex = 21;
            
            // 
            // AddSongButton
            // 
            AddSongButton.BackColor = Color.FromArgb(255, 128, 0);
            AddSongButton.Cursor = Cursors.Hand;
            AddSongButton.FlatStyle = FlatStyle.Flat;
            AddSongButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AddSongButton.ForeColor = SystemColors.ButtonHighlight;
            AddSongButton.Location = new Point(1283, 394);
            AddSongButton.Name = "AddSongButton";
            AddSongButton.Size = new Size(337, 140);
            AddSongButton.TabIndex = 20;
            AddSongButton.Text = "Add SOng";
            AddSongButton.UseVisualStyleBackColor = false;
            AddSongButton.Click += AddSongButton_Click;
            // 
            // SongName
            // 
            SongName.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SongName.Location = new Point(912, 128);
            SongName.Multiline = true;
            SongName.Name = "SongName";
            SongName.Size = new Size(708, 89);
            SongName.TabIndex = 19;
            
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(912, 14);
            label5.Name = "label5";
            label5.Size = new Size(708, 89);
            label5.TabIndex = 18;
            label5.Text = "Название трека";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(18, 128);
            label4.Name = "label4";
            label4.Size = new Size(496, 65);
            label4.TabIndex = 17;
            label4.Text = "Исполнитель";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArtistBox
            // 
            ArtistBox.Cursor = Cursors.Hand;
            ArtistBox.FlatStyle = FlatStyle.Flat;
            ArtistBox.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ArtistBox.FormattingEnabled = true;
            ArtistBox.Location = new Point(533, 139);
            ArtistBox.Name = "ArtistBox";
            ArtistBox.Size = new Size(358, 54);
            ArtistBox.TabIndex = 16;
            ArtistBox.SelectedIndexChanged += ArtistBox_SelectedIndexChanged;
            ArtistBox.TextChanged += ArtistBox_TextChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(1283, 560);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(337, 173);
            BackButton.TabIndex = 15;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(0, 192, 0);
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(912, 560);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(348, 173);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "Create Album";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 211);
            label3.Name = "label3";
            label3.Size = new Size(873, 89);
            label3.TabIndex = 7;
            label3.Text = "Список треков";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(496, 89);
            label2.TabIndex = 6;
            label2.Text = "Название альбома";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlbumName
            // 
            AlbumName.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlbumName.Location = new Point(533, 14);
            AlbumName.Multiline = true;
            AlbumName.Name = "AlbumName";
            AlbumName.Size = new Size(358, 89);
            AlbumName.TabIndex = 1;
            
            // 
            // SongListBox
            // 
            SongListBox.BackColor = SystemColors.InactiveCaptionText;
            SongListBox.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SongListBox.ForeColor = SystemColors.Window;
            SongListBox.FormattingEnabled = true;
            SongListBox.ItemHeight = 46;
            SongListBox.Location = new Point(18, 316);
            SongListBox.Name = "SongListBox";
            SongListBox.Size = new Size(873, 418);
            SongListBox.TabIndex = 0;
            SongListBox.SelectedIndexChanged += SongListBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveBorder;
            label8.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(912, 316);
            label8.Name = "label8";
            label8.Size = new Size(228, 55);
            label8.TabIndex = 25;
            label8.Text = "Жанр";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // GenreBox
            // 
            GenreBox.FormattingEnabled = true;
            GenreBox.Location = new Point(1153, 316);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(467, 40);
            GenreBox.TabIndex = 26;
            GenreBox.SelectedIndexChanged += GenreBox_SelectedIndexChanged;
            // 
            // AlbumCreatingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 877);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AlbumCreatingForm";
            Text = "AlbumCreatingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minutes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox AlbumName;
        private ListBox SongListBox;
        private Label label3;
        private Button SubmitButton;
        private ComboBox ArtistBox;
        private Button BackButton;
        private Label label4;
        private Button AddSongButton;
        private TextBox SongName;
        private Label label5;
        private Label label6;
        private NumericUpDown Minutes;
        private NumericUpDown Seconds;
        private Label label7;
        private Label label8;
        private ComboBox GenreBox;
    }
}