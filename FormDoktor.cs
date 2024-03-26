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

        SqlConnection baglantiDoktor=new SqlConnection("Data Source=DESKTOP-8J8VAOJ\\SQLEXPRESS03;Initial Catalog=HBYS;Integrated Security=SSPI");

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            baglantiDoktor.Open();
            SqlCommand komutDoktorId = new SqlCommand("select Doktorlar.doktor_id from Kullanici join Doktorlar on Kullanici.personel_id=Doktorlar.p_id where Kullanici.kullanici_id=@id", baglantiDoktor);
            komutDoktorId.Parameters.AddWithValue("@id", id);
            SqlDataReader drDoktorId = komutDoktorId.ExecuteReader();
            drDoktorId.Read();
            int doktorId = (int)drDoktorId["doktor_id"];
            drDoktorId.Close();
            baglantiDoktor.Close();
        }
        private void buttonMuayeneKaydet_Click(object sender, EventArgs e)
        {

        }

       
    }
}
