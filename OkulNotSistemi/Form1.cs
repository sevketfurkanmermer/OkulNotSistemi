﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();
            fr.numara = txtId.Text;
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgretmenMenu fr = new FrmOgretmenMenu();
            fr.Show();
            this.Hide();
        }
    }
}
