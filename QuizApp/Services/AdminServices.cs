using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization; // Use JavaScriptSerializer from System.Web.Script.Serialization
using System.Windows.Forms;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{

    public static class AdminService
    {
        private static readonly string QuestionFile = Config.QuestionBankPath;

        public static List<Question> GetQuestions()
        {
            if (!File.Exists(QuestionFile)) return new List<Question>();
            var json = File.ReadAllText(QuestionFile);
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<List<Question>>(json) ?? new List<Question>();
        }

        public static void DeleteQuestion(int id)
        {
            var questions = GetQuestions();
            var q = questions.Find(x => x.Id == id);
            if (q != null)
            {
                questions.Remove(q);
                var serializer = new JavaScriptSerializer();
                File.WriteAllText(QuestionFile, serializer.Serialize(questions));
            }
        }

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

            List<Question> allQuestions = new List<Question>();

            try
            {
                if (File.Exists(QuestionFile))
                {
                    var json = File.ReadAllText(QuestionFile);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var serializer = new JavaScriptSerializer();
                        var obj = serializer.Deserialize<List<Question>>(json);
                        if (obj != null)
                            allQuestions = obj;
                    }
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
                var serializer = new JavaScriptSerializer();
                var output = serializer.Serialize(allQuestions);
                File.WriteAllText(QuestionFile, output);
                Console.WriteLine("Soal berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal menyimpan soal: {ex.Message}");
            }
        }
        public static void SaveQuestion(Question question)
        {
            List<Question> allQuestions = new List<Question>();

            try
            {
                if (File.Exists(QuestionFile))
                {
                    var json = File.ReadAllText(QuestionFile);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var serializer = new JavaScriptSerializer();
                        var obj = serializer.Deserialize<List<Question>>(json);
                        if (obj != null)
                            allQuestions = obj;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membaca file soal: {ex.Message}");
                return;
            }

            allQuestions.Add(question);

            try
            {
                var serializer = new JavaScriptSerializer();
                var output = serializer.Serialize(allQuestions);
                File.WriteAllText(QuestionFile, output);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan soal: {ex.Message}");
            }
        }

    }
}
