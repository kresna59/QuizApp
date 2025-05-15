using System;
using System.Collections.Generic;
using System.IO;
using QuizApp.Models;
using System.Text.Json;

namespace QuizApp.Services
{

	public class QuizService


	{
		private readonly List<Question> _questions;

		public QuizService(string filePath)

		{
			if (!File.Exists(filePath)) throw new FileNotFoundException("File soal tidak ditemukan!");
			var json = File.ReadAllText(filePath);
			_questions = JsonSerializer.Deserialize<List<Question>>(json) ?? new();
		}

		public void StartQuiz()
		{
			int score = 0;

			for (int i = 0; i < _questions.Count; i++)
			{
				var q = _questions[i];
				Console.WriteLine($"\n{i + 1}. {q.Text}");
				for (int j = 0; j < q.Options.Count; j++)
					Console.WriteLine($"   {j + 1}. {q.Options[j]}");

				Console.Write("Jawaban Anda (1-4): ");
				if (!int.TryParse(Console.ReadLine(), out int answer) || answer < 1 || answer > 4)
				{
					Console.WriteLine("Jawaban tidak valid. Lewat.");
					continue;
				}

				if (q.IsCorrect(answer - 1)) score++;
			}

			Console.WriteLine($"\nSkor Akhir: {score}/{_questions.Count}");
			ScoreService.SaveScore(score, _questions.Count);
		}
	}
}