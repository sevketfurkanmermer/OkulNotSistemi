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
    public partial class FrmKulupIslemleri : Form
    {
        public FrmKulupIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LF30M9U\\MSSQLSERVER01;Initial Catalog=OkulNotSistemi;Integrated Security=True");
        public void listele()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulupler",conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }
        private void FrmKulupIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Kulupler (KulupAd) values(@p1)",conn);
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete From Tbl_Kulupler where KulupId=@p1",conn);
            cmd.Parameters.AddWithValue("@p1",txtId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Kulupler set KulupAd=@p1 where KulupId=@p2",conn);
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtId.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            listele();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
