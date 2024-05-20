using System;
using System.Collections;
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
    public partial class FormSekreter : Form
    {
        SqlConnection baglantiSekreter = new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");

        public FormSekreter()
        {
            InitializeComponent();
        }
        // Hasta

        private void textBoxHisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxHsoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxHtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxAramaTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxGuncelleIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void textBoxGuncelleSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxGuncelleTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            baglantiSekreter.Open();
            int eklenenSatirlar = hastaKaydet();
            if (eklenenSatirlar > 0)
            {
                MessageBox.Show("hasta kaydedildi");
            }
            else
            {
                MessageBox.Show("hata oluştu");
            }
            baglantiSekreter.Close();
        }
        public int hastaKaydet()
        {
            SqlCommand hastaKaydet = new SqlCommand("insert into Hasta(h_isim,h_soyisim,h_tc,h_dogumTarihi,h_tel,h_cinsiyet) values(@h_isim,@h_soyisim,@h_tc,@h_dogumTarihi,@h_tel,@h_cinsiyet)", baglantiSekreter);
            hastaKaydet.Parameters.AddWithValue("@h_isim", textBoxHisim.Text);
            hastaKaydet.Parameters.AddWithValue("@h_soyisim", textBoxHsoyisim.Text);
            hastaKaydet.Parameters.AddWithValue("@h_tc", textBoxHtc.Text);
            hastaKaydet.Parameters.AddWithValue("@h_dogumTarihi", dateTimePickerHDogunT.Value);
            hastaKaydet.Parameters.AddWithValue("@h_tel", maskedTextBoxHtel.Text);
            hastaKaydet.Parameters.AddWithValue("@h_cinsiyet", comboBoxHcinsiyet.Text);
            return hastaKaydet.ExecuteNonQuery();
        }

        private void buttonKayitAra_Click(object sender, EventArgs e)
        {
            SqlCommand kayitAra = new SqlCommand("select * from Hasta where h_tc=@h_tc", baglantiSekreter);
            kayitAra.Parameters.AddWithValue("@h_tc", textBoxAramaTc.Text);
            kayitGösterTablo(kayitAra);
        }
        private void buttonHepsiniGöster_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }
        private void tumKayitlariGoster()
        {
            SqlCommand hepsiniGoster = new SqlCommand("select * from Hasta", baglantiSekreter);
            kayitGösterTablo(hepsiniGoster);
        }
        public void kayitGösterTablo(SqlCommand sqlCommand)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void FormSekreter_Load(object sender, EventArgs e)
        {
            buttonRandevuOlustur.Enabled = false;
            dateTimePickerRancevuTarih.Enabled = false;
            groupBoxRandevu.Enabled = false;
            baglantiSekreter.Open();
            buttonKayitAra.Enabled = false;
            ArrayList polikinlikler = polikinlikGetir();
            for (int i = 0; i < polikinlikler.Count; i++)
            {
                comboBoxRandevuPolikinlik.Items.Add(polikinlikler[i]);
            }
            baglantiSekreter.Close();
        }

        private void textBoxAramaTc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAramaTc.Text.Length == 11)
            {
                buttonKayitAra.Enabled = true;
            }
            else
            {
                buttonKayitAra.Enabled = false;
            }
        }

        private void buttonKayitSill_Click(object sender, EventArgs e)
        {

            baglantiSekreter.Open();
            int[] dizi = getirSeciliKayitIdListesi();
            for (int i = 0; i < dizi.Length; i++)
            {
                kayitSil(dizi[i]);
            }
            baglantiSekreter.Close();

            tumKayitlariGoster();
        }
        private int[] getirSeciliKayitIdListesi()
        {
            int[] dizi = new int[dataGridView1.SelectedRows.Count];

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[i];
                dizi[i] = (int)row.Cells[0].Value;
            }
            return dizi;
        }
        private void kayitSil(int id)
        {
            SqlCommand kayitSil = new SqlCommand("delete from Hasta where h_id=@id", baglantiSekreter);
            kayitSil.Parameters.AddWithValue("@id", id);
            kayitSil.ExecuteScalar();
        }
        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglantiSekreter.Open();
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[i];
                    hastaGuncelle(row);
                }
                baglantiSekreter.Close();
                MessageBox.Show(dataGridView1.SelectedRows.Count + " Kayıt güncellenmiştir.");
            }
            else
            {
                MessageBox.Show("Güncellemek istediğiniz kayıtları seçiniz.");
            }
        }
        private void hastaGuncelle(DataGridViewRow row)
        {
            SqlCommand guncelle = new SqlCommand("update Hasta set h_isim=@h_isim,h_soyisim=@h_soyisim,h_tc=@h_tc,h_dogumTarihi=@h_dogumTarihi,h_tel=@h_tel,h_cinsiyet=@h_cinsiyet where h_id=@id", baglantiSekreter);
            guncelle.Parameters.AddWithValue("@id", row.Cells[0].Value);
            guncelle.Parameters.AddWithValue("@h_isim", row.Cells[1].Value);
            guncelle.Parameters.AddWithValue("@h_soyisim", row.Cells[2].Value);
            guncelle.Parameters.AddWithValue("@h_tc", row.Cells[3].Value);
            guncelle.Parameters.AddWithValue("@h_dogumTarihi", row.Cells[4].Value);
            guncelle.Parameters.AddWithValue("@h_tel", row.Cells[5].Value);
            guncelle.Parameters.AddWithValue("@h_cinsiyet", row.Cells[6].Value);
            guncelle.ExecuteScalar();
        }

        // Randevu

        private ArrayList polikinlikGetir()
        {
            SqlCommand polikinlik = new SqlCommand("select * from Polikinlik", baglantiSekreter);
            SqlDataReader drpolikinlik = polikinlik.ExecuteReader();
            ArrayList polikinlikListesi = new ArrayList();
            while (drpolikinlik.Read())
            {
                polikinlikListesi.Add(drpolikinlik["polikinlik_ad"]);
            }
            drpolikinlik.Close();
            return polikinlikListesi;
        }
        private void comboBoxRandevuPolikinlik_SelectedValueChanged(object sender, EventArgs e)
        {
            baglantiSekreter.Open();
            ArrayList doktorlar = doktorGetir();
            for (int i = 0; i < doktorlar.Count; i++)
            {
                comboBoxRandevuDoktor.Items.Add(doktorlar[i]);
            }
            baglantiSekreter.Close();
        }
        private ArrayList doktorGetir()
        {
            SqlCommand doktor = new SqlCommand("select doktor_ad from Doktorlar join Polikinlik on Doktorlar.polikinlik_id=Polikinlik.polikinlik_id where Polikinlik.polikinlik_ad=@polikinlik_ad", baglantiSekreter);
            doktor.Parameters.AddWithValue("@polikinlik_ad", comboBoxRandevuPolikinlik.SelectedItem);
            SqlDataReader drdoktor = doktor.ExecuteReader();
            ArrayList doktorListesi = new ArrayList();
            while (drdoktor.Read())
            {
                doktorListesi.Add(drdoktor["doktor_ad"]);
            }
            drdoktor.Close();
            return doktorListesi;
        }
        private void comboBoxRandevuDoktor_SelectedValueChanged(object sender, EventArgs e)
        {
            dateTimePickerRancevuTarih.Enabled = true;
            buttonRandevuOlustur.Enabled = false;
            groupBoxRandevu.Enabled = false;
        }

        private void dateTimePickerRancevuTarih_ValueChanged(object sender, EventArgs e)
        {
            buttonRandevuOlustur.Enabled = false;
            groupBoxRandevu.Enabled = true;
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            radioButton3.Checked=false;
            radioButton4.Checked=false;
            radioButton5.Checked=false;
            radioButton6.Checked=false;

            radioButton1.Enabled=true;
            radioButton2.Enabled=true;
            radioButton3.Enabled=true;
            radioButton4.Enabled=true;
            radioButton5.Enabled=true;
            radioButton6.Enabled=true;


            baglantiSekreter.Open();
            doktorRandevu();
            baglantiSekreter.Close();
        }
        private void doktorRandevu()
        {
            SqlCommand tarih = new SqlCommand("select tarih from Randevu where d_id=@d_id and tarih between @ilk_tarih and @son_tarih", baglantiSekreter);
            tarih.Parameters.AddWithValue("@ilk_tarih", dateTimePickerRancevuTarih.Value);
            tarih.Parameters.AddWithValue("@son_tarih", dateTimePickerRancevuTarih.Value.AddDays(1));
            tarih.Parameters.AddWithValue("@d_id", getirDoktorId());
            SqlDataReader drtarih = tarih.ExecuteReader();
            while (drtarih.Read())
            {
                DateTime tarihSaat = drtarih.GetDateTime(0);
                int saat = tarihSaat.Hour;
                if (saat == 9)
                {
                    radioButton1.Enabled = false;
                }
                else if (saat == 10)
                {
                    radioButton2.Enabled = false;
                }
                else if (saat == 11)
                {
                    radioButton3.Enabled = false;
                }
                else if (saat == 13)
                {
                    radioButton4.Enabled = false;
                }
                else if (saat == 14)
                {
                    radioButton5.Enabled = false;
                }
                else if (saat == 15)
                {
                    radioButton6.Enabled = false;
                }
            }
            drtarih.Close();
        }

        private void buttonRandevuOlustur_Click(object sender, EventArgs e)
        {
            baglantiSekreter.Open();
            int hId = getirHastaId();
            if (hId > 0)
            {
                int dId = getirDoktorId();
                if (dId > 0)
                {
                    DateTime randevuTarihi = dateTimePickerRancevuTarih.Value.AddHours(getirSaat());
                    SqlCommand randevu = new SqlCommand("insert into Randevu(h_id,d_id,tarih) values(@h_id,@d_id,@tarih)", baglantiSekreter);
                    randevu.Parameters.AddWithValue("@h_id", hId);
                    randevu.Parameters.AddWithValue("@d_id", dId);
                    randevu.Parameters.AddWithValue("@tarih", randevuTarihi);
                    int eklenenSatirlar = randevu.ExecuteNonQuery();
                    if (eklenenSatirlar > 0)
                    {
                        MessageBox.Show("Randevu kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("hata oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Doktor bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Tc kimlik numarasını kontrol ediniz.");
            }
            baglantiSekreter.Close();

            textBoxRandevuTc.Clear();
            comboBoxRandevuPolikinlik.Text = "";
            comboBoxRandevuDoktor.Text = "";
            comboBoxRandevuDoktor.Items.Clear();
            groupBoxRandevu.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            buttonRandevuOlustur.Enabled = false;
            dateTimePickerRancevuTarih.Enabled = false;
        }
        private int getirHastaId()
        {
            int hId = 0;
            SqlCommand hastaId = new SqlCommand("select h_id from Hasta where h_tc=@h_tc", baglantiSekreter);
            hastaId.Parameters.AddWithValue("@h_tc", textBoxRandevuTc.Text);
            SqlDataReader drId = hastaId.ExecuteReader();
            if (drId.Read())
            {
                hId = drId.GetInt32(0);
            }
            drId.Close();
            return hId;
        }
        private int getirDoktorId()
        {
            int dId = 0;
            SqlCommand doktorId = new SqlCommand("select doktor_id from Doktorlar where doktor_ad=@doktor_ad", baglantiSekreter);
            doktorId.Parameters.AddWithValue("@doktor_ad", comboBoxRandevuDoktor.SelectedItem);
            SqlDataReader drId = doktorId.ExecuteReader();
            if (drId.Read())
            {
                dId = drId.GetInt32(0);
            }
            drId.Close();
            return dId;
        }
        private int getirSaat()
        {
            if (radioButton1.Checked)
            {
                return 9;
            }
            else if (radioButton2.Checked)
            {
                return 10;
            }
            else if (radioButton3.Checked)
            {
                return 11;
            }
            else if (radioButton4.Checked)
            {
                return 13;
            }
            else if (radioButton5.Checked)
            {
                return 14;
            }
            else if (radioButton6.Checked)
            {
                return 15;
            }
            else
            {
                return 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked)
            {
                buttonRandevuOlustur.Enabled = true;
            }
        }
    }
}
