using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateQuestionaireAppBlazor
{
    public class Answers
    {
        string AnswerText { get; set; }
        bool Correct { get; set; }
        public Answers(string answerText, bool correct)
        {
            AnswerText = answerText;
            Correct = correct;
        }
        public Answers(string answerText)
        {
            AnswerText = answerText;
            Correct = false;
        }
        public Answers()
        {
            this.AnswerText = " ";
            this.Correct = false;
        }

     

    }
}
