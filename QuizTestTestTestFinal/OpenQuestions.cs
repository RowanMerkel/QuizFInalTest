using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuizTestTestTestFinal
{



    class OpenQuestions : Question
    {
        public string TheQuestion { get; set; }
        public IList Options { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
    }
}
