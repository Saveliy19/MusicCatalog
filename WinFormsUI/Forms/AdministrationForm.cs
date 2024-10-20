﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCatalog.WinFormsUI.Forms
{
    public partial class AdministrationForm : Form
    {
        private StartForm _startForm; // Поле для хранения ссылки на StartForm

        public AdministrationForm(StartForm startForm)
        {
            InitializeComponent();
            _startForm = startForm; 
        }

        private void ArtistButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _startForm.Show();
        }
    }
}