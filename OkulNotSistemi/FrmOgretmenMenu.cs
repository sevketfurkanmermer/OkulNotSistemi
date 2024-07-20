using System;
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
    public partial class FrmOgretmenMenu : Form
    {
        public FrmOgretmenMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulupIslemleri fr = new FrmKulupIslemleri();
            fr.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri fr = new FrmDersIslemleri();
            fr.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenciler fr = new FrmOgrenciler();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar fr = new FrmSınavNotlar();
            fr.Show();
        }
    }
}
