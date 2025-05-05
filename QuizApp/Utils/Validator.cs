using System;
using System.Text.RegularExpressions;

namespace QuizApp.Utils
{
    public static class Validator
    {
        /// <summary>
        /// Validates that the selected answer is within range (e.g., 1 to 4)
        /// </summary>
        public static bool ValidateAnswer(int input, int min = 1, int max = 4)
        {
            return input >= min && input <= max;
        }

        /// <summary>
        /// Validates a string is not null or whitespace
        /// </summary>
        public static bool ValidateNonEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Validates that a string only contains allowed characters (alphanumeric + space)
        /// </summary>
        public static bool ValidateAlphanumeric(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9 ]+$");
        }
    }
}
