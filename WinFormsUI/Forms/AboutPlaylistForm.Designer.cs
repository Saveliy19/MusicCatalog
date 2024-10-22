namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AboutPlaylistForm
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
            TrackListBox = new ListBox();
            label2 = new Label();
            BackButton = new Button();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // TrackListBox
            // 
            TrackListBox.BackColor = SystemColors.MenuText;
            TrackListBox.ForeColor = SystemColors.Window;
            TrackListBox.FormattingEnabled = true;
            TrackListBox.Location = new Point(756, 199);
            TrackListBox.Name = "TrackListBox";
            TrackListBox.Size = new Size(893, 580);
            TrackListBox.TabIndex = 5;
            TrackListBox.SelectedIndexChanged += TrackListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(756, 107);
            label2.Name = "label2";
            label2.Size = new Size(894, 89);
            label2.TabIndex = 6;
            label2.Text = "Track List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 128, 0);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(451, 434);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(299, 345);
            BackButton.TabIndex = 12;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.vinyl_record;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(12, 434);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(433, 345);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(738, 313);
            label3.TabIndex = 14;
            label3.Text = "Track List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // AboutPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 791);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(TrackListBox);
            Controls.Add(label1);
            Name = "AboutPlaylistForm";
            Text = "AboutPlaylistForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox TrackListBox;
        private Label label2;
        private Button BackButton;
        private PictureBox pictureBox3;
        private Label label3;
    }
}