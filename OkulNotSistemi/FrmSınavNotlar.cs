using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulNotSistemi
{
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LF30M9U\\MSSQLSERVER01;Initial Catalog=OkulNotSistemi;Integrated Security=True");

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotGetir(int.Parse(txtID.Text));
        }

        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Dersler", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersId";
            cmbDers.DataSource = dt;
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, proje;
            double ortalama;
            
            sinav1 = Convert.ToInt16(txt1.Text);
            sinav2 = Convert.ToInt16(txt2.Text);
            sinav3 = Convert.ToInt16(txt3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4.0;
            txtort.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                txtdurum.Text = "True";
            }
            else
            {
                txtdurum.Text = "False";
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDers.SelectedValue.ToString()),byte.Parse(txtID.Text),byte.Parse(txt1.Text), byte.Parse(txt2.Text), byte.Parse(txt3.Text), byte.Parse(txtproje.Text),decimal.Parse(txtort.Text),bool.Parse(txtdurum.Text),notid);
            dataGridView1.DataSource = ds.NotGetir(int.Parse(txtID.Text));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtort.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txtproje.Clear();
            txtdurum.Clear();
        }
    }
}
