using System;
using System.Collections.Generic;
using System.IO;
using QuizApp.Models;
using System.Text.Json;

namespace QuizApp.Services
{

    public static class AdminService
    {
        private static readonly string QuestionFile = "D:/csharp/QuizApp/QuizApp/Data/QuestionBank.json";

        public static void AddQuestion()
        {
            Console.WriteLine("Input soal baru:");
            Console.Write("Pertanyaan: ");
            string text = Console.ReadLine() ?? "";

            var options = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Opsi {i + 1}: ");
                options.Add(Console.ReadLine() ?? "");
            }

            Console.Write("Jawaban benar (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int correctIndex) || correctIndex < 1 || correctIndex > 4)
            {
                Console.WriteLine("Input salah.");
                return;
            }

            var question = new Question
            {
                Id = new Random().Next(1000, 9999),
                Text = text,
                Options = options,
                CorrectIndex = correctIndex - 1
            };

            List<Question> allQuestions = new();
            if (File.Exists(QuestionFile))
            {
                var json = File.ReadAllText(QuestionFile);
                allQuestions = JsonSerializer.Deserialize<List<Question>>(json) ?? new();
            }

            allQuestions.Add(question);
            File.WriteAllText(QuestionFile, JsonSerializer.Serialize(allQuestions, new JsonSerializerOptions { WriteIndented = true }));

            Console.WriteLine("Soal berhasil ditambahkan.");
        }
    }
}