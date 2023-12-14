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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategoriler fr = new FrmKategoriler();
            fr.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri fr2 = new FrmMusteri();
            fr2.Show();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MECIDLACHIN\MSSQLSERVER02; Initial Catalog = SatisVT; Persist Security Info=True;User ID = sa; Password=Azerbaijan1918;TrustServerCertificate=True");
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // Ürünlerin Durum Seviyesi
            SqlCommand komut = new SqlCommand("Execute TEST4", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Grafiğe Veri Çekme

            //chart1.Series["Akdeniz"].Points.AddXY("Adana", 24);
            //chart1.Series["Akdeniz"].Points.AddXY("Isparta", 21);

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select KATEGORIAD,COunt(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID=TBLURUNLER.KATEGORI GROUP BY KATEGORIAD", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Kategoriler"].Points.AddXY(dr[0], dr[1]);
            }
            baglanti.Close();

            // Grafiöe Veri Çekme

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select MUSTERISEHIR,COUNT(*) From TBLMUSTERI group by MUSTERISehir", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                chart2.Series["Şehirler"].Points.AddXY(dr3[0], dr3[1]);
            }
            baglanti.Close();

        }

    }
}
