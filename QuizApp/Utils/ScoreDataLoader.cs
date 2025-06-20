
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using QuizApp.Models;

namespace QuizApp.Utils
{
    public static class ScoreDataLoader
    {
        public static List<Score> LoadScores(string path)
        {
            if (!File.Exists(path))
                return new List<Score>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Score>>(json);
        }

        public static void SaveScores(string path, List<Score> scores)
        {
            var json = JsonSerializer.Serialize(scores);
            File.WriteAllText(path, json);
        }
    }
}
