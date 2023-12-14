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

namespace Proje_SQL_DB
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MECIDLACHIN\MSSQLSERVER02; Initial Catalog = SatisVT; Persist Security Info=True;User ID = sa; Password=Azerbaijan1918;TrustServerCertificate=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBLKATEGORI", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Insert into TBLKATEGORI (KATEGORIAD) values (@p1)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Kaydetme İşleminiz Başarıyla Gerçekleşti.");
            txtKategoriAd.Clear();
            txtKategoriID.Clear();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete From TBLKATEGORI Where KATEGORIID = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtKategoriID.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silme Işleminiz Başarıyla Gerçekleşti.");
            txtKategoriAd.Clear();
            txtKategoriID.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKategoriAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Update TBLKATEGORI set KATEGORIAD = @p1 Where KategoriID = @p2", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            komut4.Parameters.AddWithValue("@p2", txtKategoriID.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Güncelleme Işleminiz Başarıyla Gerçekleşti.");
            txtKategoriAd.Clear();
            txtKategoriID.Clear();
        }

        private void txtKategoriID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKategoriAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}