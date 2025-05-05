using QuizApp.Services;

Console.WriteLine("=== Sistem Quiz ===");
Console.WriteLine("1. Mulai Quiz");
Console.WriteLine("2. Tambah Soal (Admin)");
Console.Write("Pilih opsi: ");
var input = Console.ReadLine();

switch (input)
{
    case "1":
        var quiz = new QuizService("Data/QuestionBank.json");
        quiz.StartQuiz();
        break;
    case "2":
        AdminService.AddQuestion();
        break;
    default:
        Console.WriteLine("Opsi tidak dikenal.");
        break;
}
