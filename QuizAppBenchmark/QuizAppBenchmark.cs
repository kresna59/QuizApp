using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.IO;

namespace QuizApp.Benchmark
{
    [MemoryDiagnoser]
    public class QuizBenchmark
    {
        private const string SoalPath = @"C:\Users\agung\OneDrive\Documents\New folder(3)\QuizApp\QuizApp\Data\QuestionBank.json";
        private const string SkorPath = @"C:\Users\agung\OneDrive\Documents\New folder(3)\QuizApp\QuizApp\Data\ScoreLogPerf.json";

        [Benchmark]
        public void LoadSoal()
        {
            for (int i = 0; i < 10; i++)
            {
                var service = new QuizService(SoalPath);
            }
        }

        [Benchmark]
        public void SimpanSkor()
        {
            for (int i = 0; i < 10; i++)
            {
                ScoreService.SaveScore(3, 5, SkorPath);
            }
        }

        [Benchmark]
        public void ValidasiJawaban()
        {
            Validator.ValidateAnswer(3);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<QuizBenchmark>();
        }
    }
}