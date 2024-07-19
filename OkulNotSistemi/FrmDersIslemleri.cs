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
    public partial class FrmDersIslemleri : Form
    {
        public FrmDersIslemleri()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void FrmDersIslemleri_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtAd.Text);
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtId.Text));
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtAd.Text,byte.Parse(txtId.Text));
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
