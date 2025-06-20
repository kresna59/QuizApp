using System;
using System.Windows.Forms;
using QuizApp.Services;

namespace ConsoleApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Konfirmasi password tidak cocok");
                return;
            }
            if (UserService.Instance.Register(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Registrasi berhasil");
                Close();
            }
            else
            {
                MessageBox.Show("Username sudah ada");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
