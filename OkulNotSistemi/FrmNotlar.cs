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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LF30M9U\\MSSQLSERVER01;Initial Catalog=OkulNotSistemi;Integrated Security=True");
        public string numara;
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select DersAd,Sınav1,Sınav2,Sınav3,ProjeNotu,Ortalama,Durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.DersId=Tbl_Dersler.DersId where OgrId=@p1",conn);
            komut.Parameters.AddWithValue("@p1",numara);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            conn.Open();
            SqlCommand kmt = new SqlCommand("Select OgrAd,OgrSoyad from Tbl_Ogrenciler where OgrId=@n1",conn);
            kmt.Parameters.AddWithValue("@n1",numara);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0] + " " + dr[1];
            }
            conn.Close();
        }
    }
}
