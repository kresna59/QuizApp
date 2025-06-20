using System;
using System.Windows.Forms;
using QuizApp.Services;

namespace ConsoleApp2
{
    public partial class ScoreListForm : Form
    {
        public ScoreListForm()
        {
            InitializeComponent();
        }

        private void ScoreListForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = ScoreService.Instance.GetScores();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }
    }
}
