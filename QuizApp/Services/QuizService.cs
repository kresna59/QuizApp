0
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{
    public class QuizService
    {
        private static QuizService _instance;
        private static readonly object _lock = new object();

        private string questionBankPath;
        private List<Question> questions = new List<Question>();

        private QuizService()
        {
            questionBankPath = Config.QuestionBankPath;
            questions = QuestionDataLoader.LoadQuestions(questionBankPath);
        }

        public static QuizService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new QuizService();
                    return _instance;
                }
            }
        }

        public List<Question> GetQuestions()
        {
            return questions;
        }

        public void ReloadQuestions()
        {
            questions = QuestionDataLoader.LoadQuestions(questionBankPath);
        }
    }
}
