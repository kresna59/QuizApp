using System;
using System.Windows.Forms;
using QuizApp.Services;
using QuizApp.Utils;

namespace ConsoleApp2
{
    public partial class LoginForm : Form
    {
        private enum LoginState { START, INPUT_CHECK, SUCCESS, FAILURE }
        private LoginState state;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            state = LoginState.START;
            while (state != LoginState.SUCCESS && state != LoginState.FAILURE)
            {
                switch (state)
                {
                    case LoginState.START:
                        state = LoginState.INPUT_CHECK;
                        break;
                    case LoginState.INPUT_CHECK:
                        state = UserService.Instance.ValidateLogin(txtUsername.Text, txtPassword.Text)
                            ? LoginState.SUCCESS : LoginState.FAILURE;
                        break;
                }
            }

            if (state == LoginState.SUCCESS)
            {
                Session.CurrentUser = txtUsername.Text;
                this.Hide();
                var main = new MainForm();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            reg.FormClosed += (s, args) => this.Show();
            this.Hide();
            reg.Show();
        }
    }
}
