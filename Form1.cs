using System.Data.SqlClient;

namespace HBYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            string parola;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select kullanici_id from Kullanici where kullaniciAdi=@isim and sifre=@sifre", baglanti);
            komut1.Parameters.AddWithValue("@isim",textBoxKullaniciAdi.Text);
            komut1.Parameters.AddWithValue("sifre", textBoxSifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            dr.Read();
            int id = (int)dr["kullanici_id"];
            dr.Close();

            SqlCommand komut2 = new SqlCommand("select Yetki.yetki from Yetki join Kullanici_yetki on Yetki.yetki_id=Kullanici_yetki.y_id where Kullanici_yetki.k_id=@id",baglanti);
            komut2.Parameters.AddWithValue("@id", id);
            SqlDataReader dr2= komut2.ExecuteReader();
            dr2.Read();
            string yetki = (string)dr2["yetki"];
            baglanti.Close();

            switch (yetki)
            {
                case "yönetici":
                    FormYonetici yeniYonetici = new FormYonetici();
                    yeniYonetici.Show();
                    this.Hide();
                    break;

                case "doktor":
                    FormDoktor yeniDoktor = new FormDoktor();
                    yeniDoktor.Show();
                    this.Hide();
                    break;

                case "sekreter":
                    FormSekreter yeniSekreter = new FormSekreter();
                    yeniSekreter.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
