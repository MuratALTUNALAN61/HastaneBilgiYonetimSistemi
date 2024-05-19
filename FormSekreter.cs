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
            SqlCommand hastaKaydet = new SqlCommand("insert into Hasta(h_isim,h_soyisim,h_tc,h_dogumTarihi,h_tel,h_cinsiyet) values(@h_isim,@h_soyisim,@h_tc,@h_dogumTarihi,@h_tel,@h_cinsiyet)", baglantiSekreter);
            hastaKaydet.Parameters.AddWithValue("@h_isim", textBoxHisim.Text);
            hastaKaydet.Parameters.AddWithValue("@h_soyisim", textBoxHsoyisim.Text);
            hastaKaydet.Parameters.AddWithValue("@h_tc", textBoxHtc.Text);
            hastaKaydet.Parameters.AddWithValue("@h_dogumTarihi", dateTimePickerHDogunT.Value);
            hastaKaydet.Parameters.AddWithValue("@h_tel", maskedTextBoxHtel.Text);
            hastaKaydet.Parameters.AddWithValue("@h_cinsiyet", comboBoxHcinsiyet.Text);
            int eklenenSatirlar = hastaKaydet.ExecuteNonQuery();
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
        public void kayitGöster(string kayit)
        {
            SqlDataAdapter da = new SqlDataAdapter(kayit, baglantiSekreter);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonKayitAra_Click(object sender, EventArgs e)
        {
            kayitGöster("select * from Hasta where h_tc=" + textBoxAramaTc.Text);
        }
        private void buttonHepsiniGöster_Click(object sender, EventArgs e)
        {
            kayitGöster("select * from Hasta");
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
            int[] dizi = new int[dataGridView1.SelectedRows.Count];

            for(int i = 0;i<dataGridView1.SelectedRows.Count;i++)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[i];
                dizi[i] = (int)row.Cells[0].Value;
            }
            baglantiSekreter.Open();
            for(int i = 0;i<dizi.Length;i++)
            {
                SqlCommand kayitSil=new SqlCommand("delete from Hasta where h_id=@id",baglantiSekreter);
                kayitSil.Parameters.AddWithValue("@id", dizi[i]);
                kayitSil.ExecuteScalar();
            }
            baglantiSekreter.Close();
            kayitGöster("select * from Hasta");
        }



        private void textBoxGuncelleSoyisim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
