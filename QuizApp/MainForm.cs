using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizAppWinForms;

namespace ConsoleApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new QuizForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new AdminForm();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var list = new ScoreListForm();
            list.FormClosed += (s, args) => this.Close();
            list.Show();
        }

    }
}
