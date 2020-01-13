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

namespace VTYS_Odev
{
    public partial class Form2 : Form
    {
         SqlConnection baglanti;
         SqlCommand komut;
         SqlDataAdapter da;


        public Form2()
        {
            

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Bilgiler()
        {
            baglanti=new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da=new SqlDataAdapter("SELECT Musteri.ad_soyad as 'Ad Soyad', tarih,Urun.urun_icerik as 'İçerik' FROM Siparis JOIN Musteri ON Siparis.musteri_no = Musteri.musteri_no JOIN Urun ON Siparis.urun_kodu = Urun.urun_kodu",baglanti);
            DataTable tablo=new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            Bilgiler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select * from kurye", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select top 5 Urun.urun_icerik as 'Ürün Adı',count(1) AS Toplam FROM Siparis join Urun on Siparis.urun_kodu = Urun.urun_kodu Group by Urun.urun_icerik ORDER BY Toplam desc", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT Musteri.ad_soyad as 'Ad Soyad', tarih,Urun.urun_icerik as 'İçerik' FROM Siparis JOIN Musteri ON Siparis.musteri_no = Musteri.musteri_no JOIN Urun ON Siparis.urun_kodu = Urun.urun_kodu  " , baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select ilce_adi as 'İlçe Adı' from Ilce", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select top 5 Musteri.ad_soyad 'Müşteri Adı',count(1) AS Toplam FROM Siparis join Musteri on Siparis.musteri_no = Musteri.musteri_no Group by Musteri.ad_soyad ORDER BY Toplam desc", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
