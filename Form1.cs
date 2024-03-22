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
                DialogResult result = MessageBox.Show("Uygulamay� kapatmak istedi�inizden emin misiniz?",
                                                      "Uyar�",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            }
        }
    }
}
