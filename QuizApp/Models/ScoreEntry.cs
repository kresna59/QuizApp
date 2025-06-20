using System;

namespace QuizApp.Models
{
    public class ScoreEntry
    {
        public string Username { get; set; }
        public DateTime Timestamp { get; set; }
        public int Correct { get; set; }
        public int Total { get; set; }
    }
}
