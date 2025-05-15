using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizApp.Services;
using System.IO;

namespace QuizApp.Tests.Services
{
    [TestClass]
    public class ScoreServiceTests
    {
        [TestMethod]
        public void SaveScore_ShouldCreateLog()
        {
            string path = "Data/ScoreLogTest.json";
            if (File.Exists(path)) File.Delete(path);

            ScoreService.SaveScore(3, 5, path);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
