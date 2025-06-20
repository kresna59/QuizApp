using System;
using System.Windows.Forms;
using QuizApp.Services;

namespace ConsoleApp2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView.DataSource = AdminService.Instance.GetQuestions();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var add = new AddQuestion();
            add.FormClosed += (s, args) => { RefreshGrid(); this.Show(); };
            this.Hide();
            add.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                AdminService.Instance.DeleteQuestion(id);
                RefreshGrid();
            }
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
