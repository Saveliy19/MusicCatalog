namespace MusicCatalog.WinFormsUI.Forms
{
    partial class AddArtistForm
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
            BackButton = new Button();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            SubmitButton = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(1636, 727);
            panel1.TabIndex = 4;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 128, 0);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(42, 430);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(594, 257);
            BackButton.TabIndex = 11;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.hb2;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(659, 430);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(918, 257);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(486, 72);
            label2.Name = "label2";
            label2.Size = new Size(633, 46);
            label2.TabIndex = 2;
            label2.Text = "Введите имя для нового музыканта";
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(0, 192, 0);
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(983, 323);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(594, 78);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Create Artist";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 323);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(918, 78);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddArtistForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 851);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddArtistForm";
            Text = "AddArtist";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Button SubmitButton;
        private Label label2;
        private PictureBox pictureBox4;
        private Button BackButton;
    }
}