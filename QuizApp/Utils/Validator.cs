namespace QuizApp.Utils;

public static class Validator
{
    public static bool ValidateAnswer(int input)
    {
        return input >= 1 && input <= 4;
    }
}
