using QuizzAppCL;

namespace QuizzConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What's the capital of india?", new string[]{"paris","delhi","melbourne","WDC"}, 1),
                new Question("What's the capital of france?", new string[]{"paris","delhi","melbourne","WDC"}, 0),
                new Question("What's the capital of USA?", new string[]{"paris","delhi","melbourne","WDC"}, 3),
                new Question("What's the capital of russia?", new string[]{"paris","delhi","moscow","WDC"}, 2)
            };
            Quizz myQ = new Quizz(questions);
            myQ.StartQuizz();
            Console.WriteLine("Hello, World!");
        }
    }
}
