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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = MECIDLACHIN\MSSQLSERVER02; Initial Catalog = SatisVT; Persist Security Info=True;User ID = sa; Password=Azerbaijan1918;TrustServerCertificate=True");


        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * From TBLMUSTERI", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Listele();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From TBLSEHIRLER", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                cmbSehir.Items.Add(dr["SehirAd"]);
            }
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMusteriAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMusteriSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERI (MUSTERIAd,MUSTERISoyad,MUSTERISehir,MUSTERIBakiye) Values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4",decimal.Parse (txtBakiye.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Sisteme Kaydedildi");
            txtMusteriAd.Clear();
            txtMusteriID.Clear();
            txtMusteriSoyad.Clear();
            txtBakiye.Clear();
           // cmbSehir.Items.Clear();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLMUSTERI Where MUSTERIID = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMusteriID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Sistemden Silindi");
            txtMusteriAd.Clear();
            txtMusteriID.Clear();
            txtMusteriSoyad.Clear();
            txtBakiye.Clear();
            //cmbSehir.Items.Clear();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLMUSTERI set MUSTERIAD = @p1, MUSTERISOYAD = @p2, MUSTERISEHIR = @p3, MUSTERIBAKIYE = @p4 WHERE MUSTERIID = @p5", baglanti);

            komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4",decimal.Parse(txtBakiye.Text));
            komut.Parameters.AddWithValue("@p5", txtMusteriID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri  Güncellendi");
            txtMusteriAd.Clear();
            txtMusteriID.Clear();
            txtMusteriSoyad.Clear();
            txtBakiye.Clear();
            //cmbSehir.Items.Clear();
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaAd = txtMusteriAd.Text.Trim();
            string aramaSoyad = txtMusteriSoyad.Text.Trim();
            string aramaSehir = cmbSehir.Text.Trim();
            string aramaBakiye = txtBakiye.Text.Trim();

            string queryString = "SELECT * FROM TBLMUSTERI WHERE ";

            if (!string.IsNullOrEmpty(aramaAd))
            {
                queryString += "(MUSTERIAD LIKE @p1) AND ";
            }

            if (!string.IsNullOrEmpty(aramaSoyad))
            {
                queryString += "(MUSTERISOYAD LIKE @p2) AND ";
            }

            if (!string.IsNullOrEmpty(aramaSehir))
            {
                queryString += "(MUSTERISEHIR LIKE @p3) AND ";
            }

            if (!string.IsNullOrEmpty(aramaBakiye))
            {
                queryString += "(MUSTERIBAKIYE = @p4) AND ";
            }

            // Son eklenen " AND " ifadesini temizle
            queryString = queryString.TrimEnd(' ', 'A', 'N', 'D');

            SqlCommand komut = new SqlCommand(queryString, baglanti);

            if (!string.IsNullOrEmpty(aramaAd))
            {
                komut.Parameters.AddWithValue("@p1", "%" + aramaAd + "%");
            }

            if (!string.IsNullOrEmpty(aramaSoyad))
            {
                komut.Parameters.AddWithValue("@p2", "%" + aramaSoyad + "%");
            }

            if (!string.IsNullOrEmpty(aramaSehir))
            {
                komut.Parameters.AddWithValue("@p3", "%" + aramaSehir + "%");
            }

            if (!string.IsNullOrEmpty(aramaBakiye))
            {
                // Bakiye alanı için eşit kontrolü kullanıldı; gerektiğinde değiştirilebilir.
                komut.Parameters.AddWithValue("@p4", decimal.Parse(aramaBakiye));
            }

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Sonuç Bulunamadı");
                Listele();
            }
        }



    }
}
