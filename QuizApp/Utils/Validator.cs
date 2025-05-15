using System;
using System.Text.RegularExpressions;

namespace QuizApp.Utils
{
    public static class Validator
    {
        /// <summary>
        /// Validates that the selected answer is within range (e.g., 1 to 4).
        /// Throws ArgumentOutOfRangeException if invalid.
        /// </summary>
        public static bool ValidateAnswer(int input, int min = 1, int max = 4)
        {
            if (input < min || input > max)
                throw new ArgumentOutOfRangeException(nameof(input), $"Jawaban harus antara {min} sampai {max}.");

            return true;
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
