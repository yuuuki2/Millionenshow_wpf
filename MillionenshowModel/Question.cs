using System;
using System.Windows.Markup;

namespace MillionenshowModel
{
    public class Question
    {
        public string Text {  get; set; }
        public  string answerA {  get; set; }
        public  string answerB {  get; set; }
        public  string answerC {  get; set; }
        public  string answerD {  get; set; }

        public char CorrectAnwser { get; set; }

        public Question(string text, string ansA, string ansB, string ansC, string ansD, char correct) 
        {

        }


    }
}
