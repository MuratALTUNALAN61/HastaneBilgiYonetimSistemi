namespace HBYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            FormSekreter yeniSekreter = new FormSekreter();
            yeniSekreter.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Uygulamayý kapatmak istediðinizden emin misiniz?",
                                                      "Uyarý",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            }
        }
    }
}
