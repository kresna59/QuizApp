using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizApp.Services;
using System.IO;

namespace QuizApp.Tests.Services
{
    [TestClass]
    public class QuizServiceTests
    {
        [TestMethod]
        public void ShouldThrowError_IfFileNotFound()
        {
            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                var quiz = new QuizService("nonexist.json");
            });
        }
    }
}
