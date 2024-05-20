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
    public partial class FormDoktor : Form
    {
        int id;
        public FormDoktor(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection baglantiDoktor = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            baglantiDoktor.Open();

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
        private void buttonHastaBilgi_Click(object sender, EventArgs e)
        {
            baglantiDoktor.Open();
            SqlCommand siradakiHasta = new SqlCommand("select Hasta.h_id,Hasta.h_isim,Hasta.h_soyisim,Hasta.h_tc,Hasta.h_dogumTarihi,Hasta.h_tel,Hasta.h_cinsiyet,Randevu.randevu_id,Randevu.tarih from Hasta join Randevu on Hasta.h_id=Randevu.h_id where Randevu.d_id=@d_id order by Randevu.tarih", baglantiDoktor);
            siradakiHasta.Parameters.AddWithValue("@d_id", getirDoktorId(id));
            FormSekreter formSekreter = new FormSekreter();
            formSekreter.kayitGösterTablo(siradakiHasta,dataGridViewDoktor);
            baglantiDoktor.Close();
        }
    }
}
