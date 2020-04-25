using System;
using System.Collections.Generic;
using Models;
using QuizletAnswerFinder.AnswerFinding;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            

            AnswerFinder answerFinder = new AnswerFinder();
            String question = Console.ReadLine();
            String subject = Console.ReadLine();
            List<QuestionInfo> results = answerFinder.FindAnswers(question, subject);
            
            foreach(QuestionInfo questionInfo in results)
            {
                Console.WriteLine("******");
                Console.WriteLine(questionInfo.Question);
                Console.WriteLine(questionInfo.Answer);
            }

            Console.WriteLine("Done");
        }


       

    }
}
