using System;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class ScoreForm : Form
    {
        private int latestCorrect;
        private int latestTotal;
        private DateTime latestTime;

        public ScoreForm(int correct, int total)
        {
            InitializeComponent();
            latestCorrect = correct;
            latestTotal = total;
            latestTime = DateTime.Now;
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            double persen = (double)latestCorrect / latestTotal * 100;

            var display = new[]
            {
                new {
                    Tanggal = latestTime.ToString("g"),
                    Benar = latestCorrect,
                    Total = latestTotal,
                    Persentase = $"{persen:F1}%"
                }
            };

            dataGridView.DataSource = display;
        }
    }
}
