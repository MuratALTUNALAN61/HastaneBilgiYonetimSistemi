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
        }

        private void comboBoxGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGorev.SelectedIndex == 1)
            {
                comboBoxPolikinlik.Enabled = true;
            }
        }
    }
}
