using System.Collections.Generic;

namespace CreateQuestionaireAppBlazor
{
    public class Question
    {
        public string question, answer, radioquestion, radioanswer1, radioanswer2, radioanswer3, radioanswer4;

        public List<string> questionAnswer;

        public List<string> radioQuestionAnswer;

        public void setQuestion(string q) {
            this.question = q;
        }
        public void setAnswer(string a) {
            this.answer = a;
        }

        public void setRadioQuestion(string rq)
        {
            this.radioquestion = rq;
        }

        public void setRadioAnswer1(string a1)
        {
            this.radioanswer1 = a1;
        }
        public void setRadioAnswer2(string a2)
        {
            this.radioanswer2 = a2;
        }
        public void setRadioAnswer3(string a3)
        {
            this.radioanswer3 = a3;
        }
        public void setRadioAnswer4(string a4)
        {
            this.radioanswer4 = a4;
        }

        public string getQuestionAnswer(int Index) {

            return questionAnswer[Index];
        }

        public string getRadioQuestionAnswer(int Index)
        {

            return radioQuestionAnswer[Index];
        }

        public Question()
        {
            this.question = null;
            this.answer = null;
            this.questionAnswer = new List<string>();

            this.radioquestion = null;
            this.radioanswer1 = null;
            this.radioanswer2 = null;
            this.radioanswer3 = null;
            this.radioanswer4 = null;

            this.radioQuestionAnswer = new List<string>(); 
        }
        public void addQuestion()
        {
            this.questionAnswer.Add(question);
            this.questionAnswer.Add(answer);
        }

        public void addRadioQuestion()
        {
            this.radioQuestionAnswer.Add(radioquestion);
            this.radioQuestionAnswer.Add(radioanswer1);
            this.radioQuestionAnswer.Add(radioanswer2);
            this.radioQuestionAnswer.Add(radioanswer3);
            this.radioQuestionAnswer.Add(radioanswer4);
        }

    }

}
