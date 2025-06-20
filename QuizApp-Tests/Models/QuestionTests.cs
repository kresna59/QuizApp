using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizApp.Models;

namespace QuizApp.Tests.Models
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void IsCorrect_ShouldReturnTrue_WhenCorrectIndexMatched()
        {
            var q = new Question { CorrectIndex = 2 };
            Assert.IsTrue(q.IsCorrect(2));
        }

        [TestMethod]
        public void IsCorrect_ShouldReturnFalse_WhenIncorrectIndex()
        {
            var q = new Question { CorrectIndex = 1 };
            Assert.IsFalse(q.IsCorrect(3));
        }
    }
}
