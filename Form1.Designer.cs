namespace MusicCatalog
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SearchButton = new Button();
            SearchBox = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            panel1 = new Panel();
            SearchResultLabel = new Label();
            SearchResult = new ListBox();
            SearchButtonsBox = new GroupBox();
            AdminButton = new Button();
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            panel1.SuspendLayout();
            SearchButtonsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = Properties.Resources.adidas;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
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
            SearchBox.Location = new Point(12, 109);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(635, 96);
            SearchBox.TabIndex = 1;
            SearchBox.TextAlign = HorizontalAlignment.Center;
            SearchBox.TextChanged += textBox1_TextChanged;
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
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.Black;
            radioButton1.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton1.CheckAlign = ContentAlignment.MiddleCenter;
            radioButton1.Checked = true;
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton1.FlatAppearance.BorderSize = 6;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Black;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(6, 9);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(285, 83);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Все";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.Black;
            radioButton2.FlatAppearance.BorderColor = Color.White;
            radioButton2.FlatAppearance.BorderSize = 6;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(6, 365);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(283, 83);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Исполнители";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseMnemonic = false;
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.Black;
            radioButton3.FlatAppearance.BorderColor = Color.White;
            radioButton3.FlatAppearance.BorderSize = 6;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(6, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(285, 83);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "Треки";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.Black;
            radioButton4.FlatAppearance.BorderColor = Color.White;
            radioButton4.FlatAppearance.BorderSize = 6;
            radioButton4.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(6, 187);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(285, 83);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Альбомы";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.Black;
            radioButton5.FlatAppearance.BorderColor = Color.White;
            radioButton5.FlatAppearance.BorderSize = 6;
            radioButton5.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton5.ForeColor = SystemColors.ButtonHighlight;
            radioButton5.Location = new Point(6, 276);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(283, 83);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "Плейлисты";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.search_button;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(SearchResultLabel);
            panel1.Controls.Add(SearchResult);
            panel1.Location = new Point(773, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 859);
            panel1.TabIndex = 10;
            // 
            // SearchResultLabel
            // 
            SearchResultLabel.BackColor = Color.Black;
            SearchResultLabel.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchResultLabel.ForeColor = SystemColors.ButtonHighlight;
            SearchResultLabel.Location = new Point(3, 0);
            SearchResultLabel.Name = "SearchResultLabel";
            SearchResultLabel.Size = new Size(871, 95);
            SearchResultLabel.TabIndex = 1;
            SearchResultLabel.Text = "Результаты поиска";
            SearchResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchResult
            // 
            SearchResult.BackColor = Color.Black;
            SearchResult.FormattingEnabled = true;
            SearchResult.Location = new Point(3, 98);
            SearchResult.Name = "SearchResult";
            SearchResult.Size = new Size(871, 772);
            SearchResult.TabIndex = 0;
            SearchResult.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchButtonsBox
            // 
            SearchButtonsBox.BackColor = Color.MistyRose;
            SearchButtonsBox.Controls.Add(radioButton1);
            SearchButtonsBox.Controls.Add(radioButton3);
            SearchButtonsBox.Controls.Add(radioButton4);
            SearchButtonsBox.Controls.Add(radioButton2);
            SearchButtonsBox.Controls.Add(radioButton5);
            SearchButtonsBox.Location = new Point(12, 211);
            SearchButtonsBox.Name = "SearchButtonsBox";
            SearchButtonsBox.Size = new Size(298, 458);
            SearchButtonsBox.TabIndex = 11;
            SearchButtonsBox.TabStop = false;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.Black;
            AdminButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminButton.ForeColor = SystemColors.ButtonHighlight;
            AdminButton.Location = new Point(12, 675);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(755, 88);
            AdminButton.TabIndex = 12;
            AdminButton.Text = "Администрирование";
            AdminButton.UseVisualStyleBackColor = false;
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
            exitButton.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ButtonHighlight;
            exitButton.Location = new Point(12, 769);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(755, 203);
            exitButton.TabIndex = 14;
            exitButton.Text = "Выход";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1662, 984);
            Controls.Add(exitButton);
            Controls.Add(pictureBox1);
            Controls.Add(AdminButton);
            Controls.Add(SearchButtonsBox);
            Controls.Add(panel1);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1689, 1056);
            Name = "Form1";
            Text = "HardBass";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            SearchButtonsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchBox;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Panel panel1;
        private GroupBox SearchButtonsBox;
        private ListBox SearchResult;
        private Label SearchResultLabel;
        private Button AdminButton;
        private PictureBox pictureBox1;
        private Button exitButton;
    }
}
