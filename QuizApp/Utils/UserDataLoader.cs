
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using QuizApp.Models;

namespace QuizApp.Utils
{
    public static class UserDataLoader
    {
        public static List<User> LoadUsers(string path)
        {
            if (!File.Exists(path))
                return new List<User>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        public static void SaveUsers(string path, List<User> users)
        {
            var json = JsonSerializer.Serialize(users);
            File.WriteAllText(path, json);
        }
    }
}
