using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.Models;
using QuizApp.Services;
using QuizApp.Utils;

namespace ConsoleApp2
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var text = txtQuestion.Text;
            var options = new List<string> { txtOpt1.Text, txtOpt2.Text, txtOpt3.Text, txtOpt4.Text };
            int correctIndex = int.Parse(txtCorrect.Text) - 1;

            if (!Validator.ValidateNonEmpty(text) || options.Any(o => !Validator.ValidateNonEmpty(o)))
            {
                MessageBox.Show("Pertanyaan dan semua opsi harus diisi.");
                return;
            }

            var q = new Question
            {
                Id = new Random().Next(1000, 9999),
                Text = text,
                Options = options,
                CorrectIndex = correctIndex
            };

            AdminService.Instance.SaveQuestion(q);
            MessageBox.Show("Soal berhasil ditambahkan.");
            Close();
        }

    }
}
