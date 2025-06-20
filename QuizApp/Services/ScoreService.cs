
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{
    public class ScoreService
    {
        private static ScoreService _instance;
        private static readonly object _lock = new object();

        private List<Score> scores = new List<Score>();

        private ScoreService()
        {
            scores = ScoreDataLoader.LoadScores(Config.ScoreDataPath);
        }

        public static ScoreService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ScoreService();
                    return _instance;
                }
            }
        }

        public List<Score> GetScores()
        {
            return scores;
        }

        public void SaveScore(string username, int correct, int total)
        {
            scores.Add(new Score
            {
                Username = username,
                Correct = correct,
                Total = total,
                Time = System.DateTime.Now
            });

            ScoreDataLoader.SaveScores(Config.ScoreDataPath, scores);
        }
    }
}
