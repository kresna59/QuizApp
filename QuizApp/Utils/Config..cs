using System;
using System.IO;

namespace QuizApp.Utils
{
    public static class Config
    {
        public static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static string QuestionBankPath => Path.Combine(BaseDirectory, "Data", "QuestionBank.json");

        public static string ScoreLogPath => Path.Combine(BaseDirectory, "Data", "ScoreLog.json");
    }
}
