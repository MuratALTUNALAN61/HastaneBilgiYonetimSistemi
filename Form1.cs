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
            SqlCommand komutKullaniciId = new SqlCommand("select kullanici_id from Kullanici where kullaniciAdi=@isim and sifre=@sifre", baglanti);
            komutKullaniciId.Parameters.AddWithValue("@isim",textBoxKullaniciAdi.Text);
            komutKullaniciId.Parameters.AddWithValue("sifre", textBoxSifre.Text);
            SqlDataReader dr = komutKullaniciId.ExecuteReader();
            
            if (dr.Read())
            {
                int id = (int)dr["kullanici_id"];
                
                SqlCommand komutYetki = new SqlCommand("select Yetki.yetki from Yetki join Kullanici_yetki on Yetki.yetki_id=Kullanici_yetki.y_id where Kullanici_yetki.k_id=@id", baglanti);
                komutYetki.Parameters.AddWithValue("@id", id);
                SqlDataReader dr2 = komutYetki.ExecuteReader();
                

                if (dr2.Read())
                {
                    string yetki = (string)dr2["yetki"];
                    
                    switch (yetki)
                    {
                        case "y�netici":
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
                            MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Kullan�c� yetkilendirmeniz bulunmamaktad�r. Y�neticiniz ile ileti�ime ge�iniz.");
                }
                dr2.Close();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
            }
            dr.Close();
            baglanti.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
