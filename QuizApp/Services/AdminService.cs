
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{
    public class AdminService
    {
        private static AdminService _instance;
        private static readonly object _lock = new object();

        private string questionBankPath;
        private List<Question> questions = new List<Question>();
        public List<Question> GetQuestions()
        {
            return questions;
        }
        private AdminService()
        {
            questionBankPath = Config.QuestionBankPath;
            questions = QuestionDataLoader.LoadQuestions(questionBankPath);
        }

        public static AdminService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AdminService();
                    return _instance;
                }
            }
        }

       

        public void SaveQuestion(Question q)
        {
            questions.Add(q);
            QuestionDataLoader.SaveQuestions(questionBankPath, questions);
        }

        public void DeleteQuestion(int id)
        {
            questions.RemoveAll(q => q.Id == id);
            QuestionDataLoader.SaveQuestions(questionBankPath, questions);
        }
    }
}
