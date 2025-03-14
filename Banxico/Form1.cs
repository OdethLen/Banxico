namespace Banxico
{
    public partial class Form1 : Form
    {
        string User;
        string Pasword;
        public Form1()
        {
            InitializeComponent();
            User = "Odeth";
            Pasword = "e2005";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == User && txtPasword.Text == Pasword)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect pasword or user ");
                txtUser.Focus();
                txtPasword.Clear();
                txtUser.Clear();
                return;
            }

                
            

        }
    }
}
