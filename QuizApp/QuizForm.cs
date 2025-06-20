using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConsoleApp2;
using QuizApp.Models;
using QuizApp.Services;
using QuizApp.Utils;

namespace QuizAppWinForms
{
    public partial class QuizForm : Form
    {
        private List<Question> _questions;
        private int _index = 0;
        private int _score = 0;
        private Dictionary<int, Action> actionsTable;

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            try
            {
                var quizService = QuizService.Instance;
                _questions = quizService.GetQuestions();
                if (_questions.Count == 0)
                {
                    MessageBox.Show("Belum ada soal.");
                    Close();
                    return;
                }

                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat soal: " + ex.Message);
                Close();
            }
        }

        private void SetupActionsTable()
        {
            actionsTable = new Dictionary<int, Action>
            {
                { _questions.Count, FinishQuiz },
                { -1, DisplayQuestion }
            };
        }

        private void DisplayQuestion()
        {
            var q = _questions[_index];
            lblQuestion.Text = $"{_index + 1}. {q.Text}";
            radio1.Text = q.Options[0];
            radio2.Text = q.Options[1];
            radio3.Text = q.Options[2];
            radio4.Text = q.Options[3];

            ClearSelection();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsAnswerCorrect())
                _score++;

            _index++;
            SetupActionsTable();

            if (actionsTable.ContainsKey(_index))
                actionsTable[_index]();
            else
                actionsTable[-1]();
        }

        private void FinishQuiz()
        {
            ScoreService.Instance.SaveScore(Session.CurrentUser, _score, _questions.Count);
            var scoreForm = new ScoreForm(_score, _questions.Count);
            scoreForm.FormClosed += (s, args) => this.Close();
            scoreForm.Show();
        }
        private void ClearSelection()
        {
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            radio4.Checked = false;
        }

        private bool IsAnswerCorrect()
        {
            var selectedOption = -1;

            if (radio1.Checked) selectedOption = 0;
            else if (radio2.Checked) selectedOption = 1;
            else if (radio3.Checked) selectedOption = 2;
            else if (radio4.Checked) selectedOption = 3;

            if (selectedOption == -1)
                return false;

            return _questions[_index].CorrectIndex == selectedOption;
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
