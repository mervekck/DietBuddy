using DietBuddyApp.UI.Forms;

namespace DietBuddyApp.UI
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
            timer1.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}