using QuizApp.Utils;
using System;

namespace QuizApp.Tests
{
    class ValidatorTest
    {
        static void Main()
        {
            Console.WriteLine("== TESTING Validator.cs ==\n");

            Console.WriteLine("Test ValidateAnswer(2): " + Validator.ValidateAnswer(2)); // true
            Console.WriteLine("Test ValidateAnswer(5): " + Validator.ValidateAnswer(5)); // false

            Console.WriteLine("Test ValidateNonEmpty('Hello'): " + Validator.ValidateNonEmpty("Hello")); // true
            Console.WriteLine("Test ValidateNonEmpty(''): " + Validator.ValidateNonEmpty("")); // false

            Console.WriteLine("Test ValidateAlphanumeric('Quiz 123'): " + Validator.ValidateAlphanumeric("Quiz 123")); // true
            Console.WriteLine("Test ValidateAlphanumeric('Bad@Input!'): " + Validator.ValidateAlphanumeric("Bad@Input!")); // false
        }
    }
}
