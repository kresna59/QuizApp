
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using QuizApp.Models;

namespace QuizApp.Utils
{
    public static class QuestionDataLoader
    {
        public static List<Question> LoadQuestions(string path)
        {
            if (!File.Exists(path))
                return new List<Question>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Question>>(json);
        }

        public static void SaveQuestions(string path, List<Question> questions)
        {
            var json = JsonSerializer.Serialize(questions);
            File.WriteAllText(path, json);
        }
    }
}
