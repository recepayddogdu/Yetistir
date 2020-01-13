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
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti =
            new SqlConnection(@"Data Source=RECEPAYDOGDU;Initial Catalog=Yetistir;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                MessageBox.Show("Kullanıcı adı giriniz!");

                return;
            }
            else if (textBox2.Text == "")
            {
                
                    MessageBox.Show("Parola Giriniz!");
                
            }

            try
            {
                baglanti.Open();
                string sql = "Select * From Login where username=@user AND password=@pass";
                SqlParameter prm1 = new SqlParameter("user", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("pass", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    
                    Form2 a = new Form2();
                    Form1 fr2 = new Form1();
                    this.Visible = true;
                    a.Show();
                    this.Visible = false;
                    
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
                Application.Restart();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
