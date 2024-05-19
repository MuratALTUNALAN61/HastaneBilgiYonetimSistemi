﻿using System;
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
            buttonKayitAra.Enabled = false;
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
        
        private void hastaGuncelle(DataGridViewRow row)
        {
            SqlCommand guncelle = new SqlCommand("update from Hasta set h_isim=@h_isim,h_soyisim=@h_soyisim,h_tc=@h_tc,h_dogumTarihi=@h_dogumTarihi,h_tel=@h_tel,h_cinsiyet=@h_cinsiyet where h_id=@id", baglantiSekreter);
            guncelle.Parameters.AddWithValue("@id", row.Cells[0].Value);
            guncelle.Parameters.AddWithValue("@h_isim", row.Cells[1].Value);
            guncelle.Parameters.AddWithValue("@h_soyisim", row.Cells[2].Value);
            guncelle.Parameters.AddWithValue("@h_tc", row.Cells[3].Value);
            guncelle.Parameters.AddWithValue("@h_dogumTarihi", row.Cells[4].Value);
            guncelle.Parameters.AddWithValue("@h_tel", row.Cells[5].Value);
            guncelle.Parameters.AddWithValue("@h_cinsiyet", row.Cells[6].Value);
            guncelle.ExecuteScalar();
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
            }
        }
    }
}
