using System.Text.Json;

namespace QuizApp.Services;

public static class ScoreService
{
    private static readonly string ScoreFile = "Data/ScoreLog.json";

    public static void SaveScore(int correct, int total)
    {
        var result = new { timestamp = DateTime.Now, correct, total };
        List<object> allScores = new();

        if (File.Exists(ScoreFile))
        {
            var json = File.ReadAllText(ScoreFile);
            allScores = JsonSerializer.Deserialize<List<object>>(json) ?? new();
        }

        allScores.Add(result);
        var updated = JsonSerializer.Serialize(allScores, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(ScoreFile, updated);
    }
}
