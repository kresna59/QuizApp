
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Utils;

namespace QuizApp.Services
{
    public class UserService
    {
        private static UserService _instance;
        private static readonly object _lock = new object();

        private List<User> users = new List<User>();

        private UserService()
        {
            users = UserDataLoader.LoadUsers(Config.UserDataPath);
        }

        public static UserService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new UserService();
                    return _instance;
                }
            }
        }

        public bool ValidateLogin(string username, string password)
        {
            return users.Exists(u => u.Username == username && u.Password == password);
        }

        public bool Register(string username, string password)
        {
            if (users.Exists(u => u.Username == username))
                return false;

            users.Add(new User { Username = username, Password = password });
            UserDataLoader.SaveUsers(Config.UserDataPath, users);
            return true;
        }
    }
}
