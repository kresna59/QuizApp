using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace QuizApp.Tests.Services
{
    [TestClass]
    public class AdminServiceTests
    {
        [TestMethod]
        public void ShouldCreateJsonFile_IfNotExist()
        {
            string path = "Data/test_question.json";

            // 🔧 Tambahkan ini untuk memastikan foldernya ada
            Directory.CreateDirectory("Data");

            if (File.Exists(path)) File.Delete(path);
            File.WriteAllText(path, "[]");

            Assert.IsTrue(File.Exists(path));
        }

    }
}
