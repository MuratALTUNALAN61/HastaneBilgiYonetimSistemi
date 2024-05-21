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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HBYS
{
    public partial class FormDoktor : Form
    {
        int id;
        int randevuId;
        public FormDoktor(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection baglantiDoktor = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            baglantiDoktor.Open();
            getirSonrakiHastaBilgi();
            baglantiDoktor.Close();
        }
        private int getirDoktorId(int id)
        {
            SqlCommand komutDoktorId = new SqlCommand("select Doktorlar.doktor_id from Kullanici join Doktorlar on Kullanici.personel_id=Doktorlar.p_id where Kullanici.kullanici_id=@id", baglantiDoktor);
            komutDoktorId.Parameters.AddWithValue("@id", id);
            SqlDataReader drDoktorId = komutDoktorId.ExecuteReader();
            drDoktorId.Read();
            int doktorId = (int)drDoktorId["doktor_id"];
            drDoktorId.Close();
            return doktorId;
        }

        // Sonraki hasta bilgilerini getirme

        private void buttonHastaBilgi_Click(object sender, EventArgs e)
        {
            baglantiDoktor.Open();
            getirSonrakiHastaBilgi();
            baglantiDoktor.Close();
            /*
            FormSekreter formSekreter = new FormSekreter();
            formSekreter.kayitGösterTablo(siradakiHasta, dataGridViewDoktor);
            
            */
        }
        private void getirSonrakiHastaBilgi()
        {
            DateTime randevununTarihi = DateTime.Now.AddHours(-1);
            if(randevuId>0)
            {
                randevununTarihi = getirRandevuTarih();
                
            }
            SqlCommand siradakiHasta = new SqlCommand("select Hasta.h_id,Hasta.h_isim,Hasta.h_soyisim,Hasta.h_tc,Hasta.h_dogumTarihi,Hasta.h_tel,Hasta.h_cinsiyet,Randevu.randevu_id,Randevu.tarih from Hasta join Randevu on Hasta.h_id=Randevu.h_id where Randevu.d_id=@d_id and Randevu.tarih between @tarih and @tarih2 order by Randevu.tarih", baglantiDoktor);
            siradakiHasta.Parameters.AddWithValue("@d_id", getirDoktorId(id));
            siradakiHasta.Parameters.AddWithValue("@tarih", randevununTarihi.AddMinutes(11));
            siradakiHasta.Parameters.AddWithValue("@tarih2", DateTime.Now.AddHours(12));
            SqlDataReader drSiradaki = siradakiHasta.ExecuteReader();
            if (drSiradaki.Read())
            {
                labelHastaAd.Text = (string)drSiradaki["h_isim"];
                labelHastaSoyad.Text = (string)drSiradaki["h_soyisim"];
                randevuId = (int)drSiradaki["randevu_id"];
            }
            drSiradaki.Close();
        }
        private DateTime getirRandevuTarih()
        {
            DateTime randevuTarih=DateTime.Now;
            SqlCommand tarih = new SqlCommand("select tarih from Randevu where randevu_id=@randevu_id", baglantiDoktor);
            tarih.Parameters.AddWithValue("@randevu_id", randevuId);
            SqlDataReader drTarih = tarih.ExecuteReader();
            if (drTarih.Read())
            {
                randevuTarih = (DateTime)drTarih[0];
            }
            drTarih.Close();
            return randevuTarih;
        }
        // Önceki hasta bilgilerini getirme

        private void buttonOncekiHastaBilgi_Click(object sender, EventArgs e)
        {
            baglantiDoktor.Open();
            getirOncekiHastaBilgi();
            baglantiDoktor.Close();
        }
        private void getirOncekiHastaBilgi()
        {
            DateTime randevununTarihi = getirRandevuTarih();
            SqlCommand siradakiHasta = new SqlCommand("select Hasta.h_id,Hasta.h_isim,Hasta.h_soyisim,Hasta.h_tc,Hasta.h_dogumTarihi,Hasta.h_tel,Hasta.h_cinsiyet,Randevu.randevu_id,Randevu.tarih from Hasta join Randevu on Hasta.h_id=Randevu.h_id where Randevu.d_id=@d_id and Randevu.tarih between @tarih2 and @tarih order by Randevu.tarih DESC", baglantiDoktor);
            siradakiHasta.Parameters.AddWithValue("@d_id", getirDoktorId(id));
            siradakiHasta.Parameters.AddWithValue("@tarih", randevununTarihi.AddMinutes(-11));
            siradakiHasta.Parameters.AddWithValue("@tarih2", randevununTarihi.AddHours(-12));
            SqlDataReader drSiradaki = siradakiHasta.ExecuteReader();
            if (drSiradaki.Read())
            {
                labelHastaAd.Text = (string)drSiradaki["h_isim"];
                labelHastaSoyad.Text = (string)drSiradaki["h_soyisim"];
                randevuId = (int)drSiradaki["randevu_id"];
            }
            drSiradaki.Close();
        }
    }
}
