using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{
    public static class ScoreService
    {
        private static readonly string ScoreFile = Config.ScoreLogPath;

        public static void SaveScore(string username, int correct, int total)
        {
            SaveScore(username, correct, total, ScoreFile);
        }

        public static void SaveScore(string username, int correct, int total, string filePath)
        {
            if (correct < 0 || total <= 0 || correct > total)
                throw new ArgumentException("Skor tidak valid.");

            List<ScoreEntry> allScores = new List<ScoreEntry>();
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                allScores = JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
            }

            var entry = new ScoreEntry
            {
                Username = username,
                Timestamp = DateTime.Now,
                Correct = correct,
                Total = total
            };
            allScores.Add(entry);

            var updated = JsonSerializer.Serialize(allScores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updated);
        }

        public static List<ScoreEntry> GetScores()
        {
            if (!File.Exists(ScoreFile)) return new List<ScoreEntry>();
            var json = File.ReadAllText(ScoreFile);
            return JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
        }
    }
}
