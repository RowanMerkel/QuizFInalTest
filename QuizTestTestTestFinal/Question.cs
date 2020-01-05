using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuizTestTestTestFinal
{
    interface Question
    {
        string TheQuestion { get; set; }
        string Category { get; set; }
        string Answer { get; set; }
        int Difficulty { get; set; }

    }
}
