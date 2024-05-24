using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBYS
{
    public partial class FormYonetici : Form
    {
        int poliId;
        int yetkilendirmeId;
        int kullaniciId;

        public FormYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglantiYonetici = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");


        private void FormYonetici_Load(object sender, EventArgs e)
        {
            buttonKayitEkle.Enabled = false;
            comboBoxPolikinlik.Enabled = false;
            baglantiYonetici.Open();
            getirPolikinlik();
            getirButunPersoneller();
            baglantiYonetici.Close();
        }
        private void ekleButonErisim()
        {
            if ((textBoxP_Isim.Text.Length != 0) && (textBoxP_Soyisim.Text.Length != 0) && (textBoxP_Tc.Text.Length == 11)) 
            {
                buttonKayitEkle.Enabled = true;
            }
        }
        private void getirPolikinlik()
        {
            SqlCommand polikinlik = new SqlCommand("select polikinlik_ad from Polikinlik", baglantiYonetici);
            SqlDataReader drPolikinlik = polikinlik.ExecuteReader();
            while (drPolikinlik.Read())
            {
                comboBoxPolikinlik.Items.Add(drPolikinlik[0]);
            }
            drPolikinlik.Close();
        }

        private void comboBoxGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGorev.SelectedIndex == 1)
            {
                comboBoxPolikinlik.Enabled = true;
            }
        }

        // Personel ekleme
        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();
            //personel
            int eklenenPersonel = personelEkle();
            if (eklenenPersonel > 0)
            {
                MessageBox.Show("Personel kaydı yapılmıştır.");

                //doktor
                if (comboBoxGorev.SelectedIndex == 1)
                {
                    int eklenenDoktor = doktorEkle();
                    if (eklenenDoktor > 0)
                    {
                        MessageBox.Show("Doktor kaydı yapılmıştır");
                    }
                    else
                    {
                        MessageBox.Show("Doktor kaydında hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hata oluştu. ");
            }
            baglantiYonetici.Close();
        }
        private int personelEkle()
        {
            DateTime tarih = dateTimePickerP_DogumTarihi.Value;
            DateTime sadeceTarih = tarih.Date;
            SqlCommand personelEkle = new SqlCommand("insert into Personel(p_isim,p_soyisim,p_tc,p_dogumTarihi,p_tel,p_cinsiyet,p_adres,p_mail,p_gorevi)" +
                "values(@p_isim,@p_soyisim,@p_tc,@p_dogumTarihi,@p_tel,@p_cinsiyet,@p_adres,@p_mail,@p_gorevi)", baglantiYonetici);
            personelEkle.Parameters.AddWithValue("@p_isim", textBoxP_Isim.Text);
            personelEkle.Parameters.AddWithValue("@p_soyisim", textBoxP_Soyisim.Text);
            personelEkle.Parameters.AddWithValue("@p_tc", textBoxP_Tc.Text);
            personelEkle.Parameters.AddWithValue("@p_tel", textBoxP_Telefon.Text);
            personelEkle.Parameters.AddWithValue("@p_cinsiyet", comboBoxHcinsiyet.Text);
            personelEkle.Parameters.AddWithValue("@p_adres", textBoxP_Adres.Text);
            personelEkle.Parameters.AddWithValue("@p_mail", textBoxP_Mail.Text);
            personelEkle.Parameters.AddWithValue("@p_gorevi", comboBoxGorev.Text);
            personelEkle.Parameters.AddWithValue("@p_dogumTarihi", sadeceTarih);
            return personelEkle.ExecuteNonQuery();
        }

        // Database doktor ekleme

        private int getirPersonelId()
        {
            int pId = 0;
            SqlCommand personelId = new SqlCommand("select p_id from Personel where p_tc=@p_tc", baglantiYonetici);
            personelId.Parameters.AddWithValue("@p_tc", textBoxP_Tc.Text);
            SqlDataReader drPersonelId = personelId.ExecuteReader();
            if (drPersonelId.Read())
            {
                pId = drPersonelId.GetInt32(0);
            }
            drPersonelId.Close();
            return pId;
        }
        private int getirPolikinlikId()
        {
            int poliId = 0;
            SqlCommand polikinlikId = new SqlCommand("select polikinlik_id from Polikinlik where polikinlik_ad=@polikinlik_ad", baglantiYonetici);
            polikinlikId.Parameters.AddWithValue("@polikinlik_ad", comboBoxPolikinlik.Text);
            SqlDataReader drPolikinlikId = polikinlikId.ExecuteReader();
            if (drPolikinlikId.Read())
            {
                poliId = drPolikinlikId.GetInt32(0);
            }
            drPolikinlikId.Close();
            return poliId;
        }
        private int doktorEkle()
        {
            SqlCommand doktorEkle = new SqlCommand("insert into Doktorlar(p_id,polikinlik_id,doktor_ad) values(@p_id,@polikinlik_id,@doktor_ad)", baglantiYonetici);
            doktorEkle.Parameters.AddWithValue("@p_id", getirPersonelId());
            doktorEkle.Parameters.AddWithValue("@polikinlik_id", getirPolikinlikId());
            doktorEkle.Parameters.AddWithValue("@doktor_ad", textBoxP_Isim.Text + " " + textBoxP_Soyisim.Text);
            return doktorEkle.ExecuteNonQuery();
        }

        // Personel kaydı görüntüleme

        private void buttonKayitAra_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();
            getirPersonelKaydi();
            baglantiYonetici.Close();
        }
        private void getirPersonelKaydi()
        {
            FormSekreter tabloAl = new FormSekreter();
            SqlCommand personelKaydi = new SqlCommand("select * from Personel where p_tc=@p_tc", baglantiYonetici);
            personelKaydi.Parameters.AddWithValue("@p_tc", textBoxP_TcArama.Text);
            tabloAl.kayitGösterTablo(personelKaydi, dataGridViewPersonel);
        }

        // bütün personel kayıtlarını görüntüleme

        private void buttonButunPersoneller_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();
            getirButunPersoneller();
            baglantiYonetici.Close();
        }
        private void getirButunPersoneller()
        {
            SqlCommand hepsiniGoster = new SqlCommand("select * from Personel order by p_id", baglantiYonetici);
            FormSekreter butunTabloAl = new FormSekreter();
            butunTabloAl.kayitGösterTablo(hepsiniGoster, dataGridViewPersonel);
        }

        // personel kaydı silme

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();
            string silinecekPersonelTc = textBoxP_TcArama.Text;
            personelSil(silinecekPersonelTc);

            getirButunPersoneller();
            baglantiYonetici.Close();
        }
        private void personelSil(string tc)
        {
            int personelId = getirPersonelId(tc);
            if (personelId > 0)
            {
                int kullaniciId = getirKullaniciId(personelId);
                if (kullaniciId > 0)
                {
                    yetkiSil(kullaniciId);
                    kullaniciSil(kullaniciId);
                    guncellePersonelDurumu(personelId, "ayrıldı");
                    MessageBox.Show("Personel silindi");
                }
                else
                {
                    MessageBox.Show("Kullanici bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Personel bulunamadı.");
            }
        }
        private void kullaniciSil(int kullaniciId)
        {
            SqlCommand cmdKullaniciSil = new SqlCommand("delete from Kullanici where kullanici_id=@k_id", baglantiYonetici);
            cmdKullaniciSil.Parameters.AddWithValue("@k_id", kullaniciId);
            cmdKullaniciSil.ExecuteScalar();
        }
        private void yetkiSil(int kullaniciId)
        {
            SqlCommand cmdYetkiSil = new SqlCommand("delete from Kullanici_yetki where k_id=@k_id", baglantiYonetici);
            cmdYetkiSil.Parameters.AddWithValue("@k_id", kullaniciId);
            cmdYetkiSil.ExecuteScalar();
        }
        private void guncellePersonelDurumu(int personelId, string durum)
        {
            SqlCommand cmdPersonelDurumu = new SqlCommand("update Personel set p_durumu=@durum where p_id=@personelId", baglantiYonetici);
            cmdPersonelDurumu.Parameters.AddWithValue("@durum", durum);
            cmdPersonelDurumu.Parameters.AddWithValue("@personelId", personelId);
            cmdPersonelDurumu.ExecuteScalar();
        }
        private int getirKullaniciId(int personelId)
        {
            int kullaniciId = 0;
            SqlCommand cmdKullaniciId = new SqlCommand("select kullanici_id from Kullanici where personel_id=@p_id", baglantiYonetici);
            cmdKullaniciId.Parameters.AddWithValue("@p_id", personelId);
            SqlDataReader drKullaniciId = cmdKullaniciId.ExecuteReader();
            if (drKullaniciId.Read())
            {
                kullaniciId = drKullaniciId.GetInt32(0);
            }
            drKullaniciId.Close();
            return kullaniciId;
        }
        private int getirPersonelId(string tc)
        {
            int personelId = 0;
            SqlCommand cmdPersonelId = new SqlCommand("select p_id from Personel where p_tc=@p_tc", baglantiYonetici);
            cmdPersonelId.Parameters.AddWithValue("@p_tc", tc);
            SqlDataReader drPersonelId = cmdPersonelId.ExecuteReader();
            if (drPersonelId.Read())
            {
                personelId = drPersonelId.GetInt32(0);
            }
            drPersonelId.Close();
            return personelId;
        }

        // Kullanıcı oluşturma

        private void buttonKullaniciOlustur_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();
            int eklenenKullanici = kullaniciEkle();
            getirYetkiId(eklenenKullanici);
            getirKullaniciId();
            int eklenenYetki = yetkiEkle();
            if (eklenenYetki > 0)
            {
                MessageBox.Show("Kullanıcı oluşturuldu");
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
            baglantiYonetici.Close();
        }
        private int kullaniciEkle()
        {
            SqlCommand kullanici = new SqlCommand("insert into Kullanici(personel_id,kullaniciAdi,sifre) values(@personel_id,@kullaniciAdi,@sifre)", baglantiYonetici);
            kullanici.Parameters.AddWithValue("@personel_id", labelPersonelId.Text);
            kullanici.Parameters.AddWithValue("@kullaniciAdi", textBoxKullaniciAdi.Text);
            kullanici.Parameters.AddWithValue("@sifre", textBoxKullaniciSifre.Text);
            return kullanici.ExecuteNonQuery();
        }
        private void getirYetkiId(int eklenenKullanici)
        {
            if (eklenenKullanici > 0)
            {
                SqlCommand yetkiId = new SqlCommand("select Yetki.yetki_id from Personel join Yetki on Personel.p_gorevi=Yetki.yetki where Personel.p_id=@p_id", baglantiYonetici);
                yetkiId.Parameters.AddWithValue("@p_id", labelPersonelId.Text);
                SqlDataReader drYetkiId = yetkiId.ExecuteReader();
                if (drYetkiId.Read())
                {
                    yetkilendirmeId = drYetkiId.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Bu görev yetki sahibi değildir");
                }
                drYetkiId.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı oluşturulurken hata meydana geldi.");
            }
        }
        private void getirKullaniciId()
        {
            SqlCommand sqlkullaniciId = new SqlCommand("select kullanici_id from Kullanici where personel_id=@personel_id", baglantiYonetici);
            sqlkullaniciId.Parameters.AddWithValue("@personel_id", labelPersonelId.Text);
            SqlDataReader drKullaniciId = sqlkullaniciId.ExecuteReader();
            if (drKullaniciId.Read())
            {
                kullaniciId = drKullaniciId.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
            drKullaniciId.Close();
        }
        private int yetkiEkle()
        {
            SqlCommand yetkiEkle = new SqlCommand("insert into Kullanici_yetki(y_id,k_id) values(@y_id,@k_id)", baglantiYonetici);
            yetkiEkle.Parameters.AddWithValue("@y_id", yetkilendirmeId);
            yetkiEkle.Parameters.AddWithValue("@k_id", kullaniciId);
            return yetkiEkle.ExecuteNonQuery();
        }

        // label ıd ekleme

        private int seciliPersonelId()
        {
            int personelId = 0;
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPersonel.SelectedRows[0];
                personelId = (int)row.Cells[0].Value;
                return personelId;
            }
            return personelId;
        }

        private void dataGridViewPersonel_SelectionChanged(object sender, EventArgs e)
        {
            labelPersonelId.Text = seciliPersonelId().ToString();
        }

        // çıkış yap

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void textBoxP_Isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxP_Soyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxP_Tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxP_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxP_Isim_TextChanged(object sender, EventArgs e)
        {
            ekleButonErisim();
        }

        private void textBoxP_Soyisim_TextChanged(object sender, EventArgs e)
        {
            ekleButonErisim();
        }

        private void textBoxP_Tc_TextChanged(object sender, EventArgs e)
        {
            ekleButonErisim();
        }
    }
}
