using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizTestTestTestFinal
{
    class QuizDemo
    {
        IList<Question> listOfQuestions = new List<Question>();
        IEnumerable<Question> displayDifficultyQuestions = new List<Question>();
        IEnumerable<Question> sortQuestionsOnDifficulty = new List<Question>();

        public QuizDemo()
        {
            InitQuestions();

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

            listOfQuestions.Add(question3);
            listOfQuestions.Add(question1);
            listOfQuestions.Add(question2);
        }

        public void ConsoleApp()
        {
            Console.WriteLine("Dit is een quiz. Succes!");
            Console.WriteLine("Als u met makkelijke vragen wilt beginnen, type Ja. Type anders Nee.");
            Console.WriteLine("Of als u alleen met een bepaalde moeilijkheidsgraad wilt beginnen, kunt u m invoeren en daarna 1, 2 of 3 kiezen.");

            Console.WriteLine("Als u wilt stoppen, druk op escape.\n");

            /*
            foreach (Question question in listOfQuestions)
            {
                Console.WriteLine(question.TheQuestion);
                Console.WriteLine("Moeilijkheidsgraad: " + question.Difficulty);
            }*/

                string invoer = Console.ReadLine();

                if (invoer.ToLower().Equals("ja"))
                {
                    sortQuestionsOnDifficulty = SortQuestionsOnDifficulty(listOfQuestions);

                    foreach (Question question in sortQuestionsOnDifficulty)
                    {
                        Console.WriteLine(question.TheQuestion);
                        Console.WriteLine("Moeilijkheidsgraad: " + question.Difficulty);

                        Console.WriteLine("Wat is het antwoord?");
                        Console.WriteLine(CompareAnswer(question, Console.ReadLine()));
                    }
                }
                else if (invoer.ToLower().Equals("nee"))
                {
                    foreach (Question question in listOfQuestions)
                    {
                        Console.WriteLine(question.TheQuestion);
                        Console.WriteLine("Moeilijkheidsgraad: " + question.Difficulty);

                        Console.WriteLine("Wat is het antwoord?");
                        Console.WriteLine(CompareAnswer(question, Console.ReadLine()));
                    }
                }
                else if(invoer.ToLower().Equals("m"))
                {
                    Console.WriteLine("Kies een moeilijkheidsgraad: 1, 2 of 3");
                    string invoer2 = Console.ReadLine();

                    for (int i = 1; i <= 3; i++)
                    {
                        if (invoer2.Equals(i.ToString()))
                        {
                            displayDifficultyQuestions = DisplayDifficultyQuestions(listOfQuestions, i);

                            foreach (Question question in displayDifficultyQuestions)
                            {
                                Console.WriteLine(question.TheQuestion);
                                Console.WriteLine("Moeilijkheidsgraad: " + question.Difficulty);

                                Console.WriteLine("Wat is het antwoord?");
                                CompareAnswer(question, Console.ReadLine());
                            }

                        }
                    }
            }

                
                


        }

        //Sort questions from easy to hard.
        public IEnumerable<Question> SortQuestionsOnDifficulty(IEnumerable<Question> question)
        {
            var list =
               from diff in listOfQuestions
               orderby diff.Difficulty ascending
               select diff;
            return list;
        }

        //Display only the questions with a selected difficulty.
        public IEnumerable<Question> DisplayDifficultyQuestions(IEnumerable<Question> question, int difficulty)
        {
            IEnumerable<Question> list =
               from diff in listOfQuestions
               where diff.Difficulty == difficulty
               select diff;
            return list;
        }


        //Compares the answer given against the answer that is provided with the question.
        public string CompareAnswer(Question question, string answer)
        {
            if(question.Answer.ToLower() == answer.ToLower()){
                return answer + " is the correct answer. Good job!";
            }
            return answer + " is not the correct answer. The correct answer is: " + question.Answer;
        }
    }
}
