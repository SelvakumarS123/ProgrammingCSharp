using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzAppCL
{
    public class Quizz
    {
        private Question[] questions;
        public Quizz(Question[] questions) {
            this.questions = questions;//this-> used to access the members of the same object
        }

        public void StartQuizz()
        {
            Console.WriteLine("Welcome b*tch");
            int questionNumber = 1;
            foreach (Question question in questions) {
                Console.Write("Question " + questionNumber++ + " : ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsAnsrIndex(userChoice))
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct Answer: {question.Options[question.AnsrIndex]}");
                }
            }
        }
        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Options.Length; i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("");
                Console.Write(i+1); 
                Console.ResetColor();
                Console.WriteLine($". {question.Options[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Enter Your Ansr Index");
            string input = Console.ReadLine();
            int choice = 0;
            while (! int.TryParse(input, out choice)||choice<1||choice>4)
            {
                Console.WriteLine("invalid choice");
                input = Console.ReadLine();
            }
            return choice-1; //0 indexing
        }
    }
}
