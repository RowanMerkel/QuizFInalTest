using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTestTestTestFinal
{
    class QuizDemo
    {
        IList<OpenQuestions> listOfOpenQuestions = new List<OpenQuestions>();

        public QuizDemo()
        {
            initQuestions();

             
        }


        //Initializes the questions before hand.
        public void initQuestions()
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

        }

        //Compares the answer given against the answer that is provided with the question.
        public string compareAnswer(OpenQuestions question, string answer)
        {
            if(question.Answer.ToLower() == answer.ToLower()){
                return answer + " is the correct answer. Good job!";
            }
            return answer + " is not the correct answer. The correct answer is: " + question.Answer;
        }
    }
}
