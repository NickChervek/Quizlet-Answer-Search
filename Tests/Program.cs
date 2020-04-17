using System;
using QuizletAnswerFinder.AnswerFinding;
namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            AnswerFinder answerFinder = new AnswerFinder();
            String results = answerFinder.FindAnswers("What is SQL", "sql");
            Console.WriteLine(results);
        }
    }
}
