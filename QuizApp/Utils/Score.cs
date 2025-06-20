
using System;

namespace QuizApp.Models
{
    public class Score
    {
        public string Username { get; set; }
        public int Correct { get; set; }
        public int Total { get; set; }
        public DateTime Time { get; set; }
    }
}
