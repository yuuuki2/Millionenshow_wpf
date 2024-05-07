using System;
using System.Windows.Markup;

namespace MillionenshowModel
{
    public class Question
    {
        public string Text {  get; set; }
        public  string AnswerA {  get; set; }
        public  string AnswerB {  get; set; }
        public  string AnswerC {  get; set; }
        public  string AnswerD {  get; set; }

        public char CorrectAnwser { get; set; }

        public Question(string text, string ansA, string ansB, string ansC, string ansD, char correct) 
        {
            Text = text;
            AnswerA = ansA;
            AnswerB = ansB;
            AnswerC = ansC;
            AnswerD = ansD;
            CorrectAnwser = correct;
        }


    }
}
