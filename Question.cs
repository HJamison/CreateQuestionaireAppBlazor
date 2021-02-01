using System.Collections.Generic;

namespace CreateQuestionaireAppBlazor
{
    public class Question
    {
        public string question, answer;

        List<string> questionAnswer;

        public void setQuestion(string q) {
            this.question = q;
        }
        public void setAnswer(string a) {
            this.answer = a;
        }

        public string getQuestionAnswer(int Index) {

            return questionAnswer[Index];
        }

        public Question()
        {
            this.question = null;
            this.answer = null;
            this.questionAnswer = new List<string>(); 
        }
        public void addQuestion()
        {
            this.questionAnswer.Add(question);
            this.questionAnswer.Add(answer);
        }

    }
}
