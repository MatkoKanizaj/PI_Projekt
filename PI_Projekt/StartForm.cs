

namespace PI_Projekt
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BtnZaposlenik_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide(); 
        }

        private void BtnKupac_Click(object sender, EventArgs e)
        {
           
        }
    }
}
