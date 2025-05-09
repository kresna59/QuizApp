using System.Collections.Generic;

namespace QuizApp.Models
{
    
public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public List<string> Options { get; set; } = new();
    public int CorrectIndex { get; set; }

    public bool IsCorrect(int answerIndex) => answerIndex == CorrectIndex;
}
}
