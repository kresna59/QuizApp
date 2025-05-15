using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{

    public static class AdminService
    {
        private static readonly string QuestionFile = Config.QuestionBankPath;

        public static void AddQuestion()
        {
            Console.WriteLine("Input soal baru:");
            Console.Write("Pertanyaan: ");
            string text = Console.ReadLine() ?? "";

            if (!Validator.ValidateNonEmpty(text))
            {
                Console.WriteLine("Pertanyaan tidak boleh kosong.");
                return;
            }

            var options = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Opsi {i + 1}: ");
                string input = Console.ReadLine() ?? "";
                if (!Validator.ValidateNonEmpty(input))
                {
                    Console.WriteLine("Opsi tidak boleh kosong.");
                    return;
                }
                options.Add(input);
            }

            Console.Write("Jawaban benar (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int correctIndex) || !Validator.ValidateAnswer(correctIndex))
            {
                Console.WriteLine("Input jawaban salah. Masukkan angka 1–4.");
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

            try
            {
                if (File.Exists(QuestionFile))
                {
                    var json = File.ReadAllText(QuestionFile);
                    allQuestions = JsonSerializer.Deserialize<List<Question>>(json) ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal membaca file soal: {ex.Message}");
                return;
            }

            allQuestions.Add(question);

            try
            {
                var output = JsonSerializer.Serialize(allQuestions, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(QuestionFile, output);
                Console.WriteLine("Soal berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal menyimpan soal: {ex.Message}");
            }
        }
    }
}