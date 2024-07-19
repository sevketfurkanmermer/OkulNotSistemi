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
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter  ds= new DataSet1TableAdapters.DataTable1TableAdapter();

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LF30M9U\\MSSQLSERVER01;Initial Catalog=OkulNotSistemi;Integrated Security=True");
        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.OgrenciListele();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Kulupler",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulup.DisplayMember = "KulupAd";
            cmbkulup.ValueMember = "KulupId";
            cmbkulup.DataSource= dt;
            conn.Close();

        }
        string c = "";
        private void btnekle_Click(object sender, EventArgs e)
        {
            
            
            ds.OgrenciEkle(txtAd.Text,txtsoyad.Text,byte.Parse(cmbkulup.SelectedValue.ToString()),c);
            dataGridView1.DataSource = ds.OgrenciListele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtId.Text));
            dataGridView1.DataSource = ds.OgrenciListele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtAd.Text,txtsoyad.Text,byte.Parse(cmbkulup.SelectedValue.ToString()) , c,int.Parse(txtId.Text));
            dataGridView1.DataSource = ds.OgrenciListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkulup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (radioKiz.Text == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())
            {
                radioKiz.Checked = true;
            }
            else if(RadioErkek.Text== dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())
            {
                RadioErkek.Checked = true;
            }
            else
            {
                RadioErkek.Checked = false;
                radioKiz.Checked = false;
            }
            dataGridView1.DataSource = ds.OgrenciListele();
            conn.Close();
        }

        private void RadioErkek_CheckedChanged(object sender, EventArgs e)
        {
           
            if (RadioErkek.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void radioKiz_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKiz.Checked == true)
            {
                c = "Kız";
            }
           
        }

        private void btnara_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.OgrenciAra(txtara.Text);
        }
    }
}
