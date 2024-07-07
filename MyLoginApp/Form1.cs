using System;
using System.Windows.Forms;

namespace MyLoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");
        }
    }
}
