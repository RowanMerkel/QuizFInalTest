using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizTestTestTestFinal
{
    class QuizDemo
    {
        IList<OpenQuestions> listOfOpenQuestions = new List<OpenQuestions>();

        public QuizDemo()
        {
            InitQuestions();

            DisplayDifficultyQuestions(listOfOpenQuestions, 2);

            ConsoleApp();
        }


        //Initializes the questions before hand.
        public void InitQuestions()
        {
            OpenQuestions question1 = new OpenQuestions();
            question1.TheQuestion = "What is the capital of the Netherlands?";
            question1.Answer = "Amsterdam";
            question1.Category = "Topography";
            question1.Difficulty = 1;

            OpenQuestions question2 = new OpenQuestions();
            question2.TheQuestion = "The value of pi with two decimals.";
            question2.Answer = "3.14";
            question2.Category = "General knowledge";
            question2.Difficulty = 2;

            OpenQuestions question3 = new OpenQuestions();
            question3.TheQuestion = "What is the answer to the Ultimate Question of Life, the Universe, and Everything?";
            question3.Answer = "42";
            question3.Category = "General knowledge";
            question3.Difficulty = 3;

            listOfOpenQuestions.Add(question3);
            listOfOpenQuestions.Add(question1);
            listOfOpenQuestions.Add(question2);
        }

        public void ConsoleApp()
        {
            Console.WriteLine("Dit is een quiz. Succes!");
            Console.WriteLine("Als u met makkelijke vragen wilt beginnen, type 1.");
            Console.WriteLine("Als u wilt stoppen, druk op escape.");

            Boolean x = true;



        }

        //Sort questions from easy to hard.
        public IEnumerable<Question> SortQuestionsOnDifficulty(IEnumerable<Question> question)
        {
            var list =
               from diff in listOfOpenQuestions
               orderby diff.Difficulty ascending
               select diff;
            return list;
        }

        //Display only the questions with a selected difficulty.
        public IEnumerable<Question> DisplayDifficultyQuestions(IEnumerable<Question> question, int difficulty)
        {
            IEnumerable<Question> list =
               from diff in listOfOpenQuestions
               where diff.Difficulty == difficulty
               select diff;
            Console.WriteLine(list.First().TheQuestion);
            return list;
        }


        //Compares the answer given against the answer that is provided with the question.
        public string CompareAnswer(OpenQuestions question, string answer)
        {
            if(question.Answer.ToLower() == answer.ToLower()){
                return answer + " is the correct answer. Good job!";
            }
            return answer + " is not the correct answer. The correct answer is: " + question.Answer;
        }
    }
}
