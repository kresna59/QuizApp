using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizApp.Utils;

namespace QuizApp.Tests.Utils
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void ValidateAnswer_ShouldReturnTrue_ForValidInput()
        {
            Assert.IsTrue(Validator.ValidateAnswer(1));
            Assert.IsTrue(Validator.ValidateAnswer(4));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateAnswer_ShouldThrow_ForInvalidInput()
        {
            Validator.ValidateAnswer(5);
        }
    }
}
