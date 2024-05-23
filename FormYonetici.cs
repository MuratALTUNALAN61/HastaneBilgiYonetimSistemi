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
        public FormYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglantiYonetici = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");


        private void FormYonetici_Load(object sender, EventArgs e)
        {
            comboBoxPolikinlik.Enabled = false;
            baglantiYonetici.Open();
            getirPolikinlik();
            getirButunPersoneller();
            baglantiYonetici.Close();
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
            personelSil();
            getirButunPersoneller();
            baglantiYonetici.Close();
        }
        private void personelSil()
        {
            SqlCommand personelSil = new SqlCommand("update Personel set p_durumu='ayrıldı' where p_tc=@p_tc", baglantiYonetici);
            personelSil.Parameters.AddWithValue("@p_tc", textBoxP_TcArama.Text);
            personelSil.ExecuteScalar();
        }

        // Kullanıcı oluşturma

        private void buttonKullaniciOlustur_Click(object sender, EventArgs e)
        {
            baglantiYonetici.Open();

            baglantiYonetici.Close();
        }
        private void kullaniciEkle()
        {

        }

        // label ıd ekleme

        private int seciliPersonelId()
        {
            int personelId=0;
            if(dataGridViewPersonel.SelectedRows.Count > 0)
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
    }
}
