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
            baglanti.Open();

            int id = getirId(textBoxKullaniciAdi.Text, textBoxSifre.Text);
            if (id != 0)
            {
                string yetki = getirYetki(id);
                if (yetki != null)
                {
                    switch (yetki)
                    {
                        case "yönetici":
                            FormYonetici yeniYonetici = new FormYonetici();
                            yeniYonetici.Show();
                            this.Hide();
                            break;

                        case "doktor":
                            FormDoktor yeniDoktor = new FormDoktor(id);
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
                else
                {
                    MessageBox.Show("Kullanýcý yetkilendirmeniz bulunmamaktadýr. Yöneticiniz ile iletiþime geçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
            }
            baglanti.Close();
        }
        private int getirId(string kullaniciAdi, string kullaniciSifre)
        {
            int id = 0;
            SqlCommand komutKullaniciId = new SqlCommand("select kullanici_id from Kullanici where kullaniciAdi=@isim and sifre=@sifre", baglanti);
            komutKullaniciId.Parameters.AddWithValue("@isim", kullaniciAdi);
            komutKullaniciId.Parameters.AddWithValue("sifre", kullaniciSifre);
            SqlDataReader dr = komutKullaniciId.ExecuteReader();
            if (dr.Read())
            {
                id = (int)dr["kullanici_id"];
            }
            dr.Close();
            return id;
        }
        private string getirYetki(int id)
        {
            string yetki = null;
            SqlCommand komutYetki = new SqlCommand("select Yetki.yetki from Yetki join Kullanici_yetki on Yetki.yetki_id=Kullanici_yetki.y_id where Kullanici_yetki.k_id=@id", baglanti);
            komutYetki.Parameters.AddWithValue("@id", id);
            SqlDataReader dr2 = komutYetki.ExecuteReader();
            if (dr2.Read())
            {
                yetki = (string)dr2["yetki"];
            }
            dr2.Close();
            return yetki;
        }
    }
}
