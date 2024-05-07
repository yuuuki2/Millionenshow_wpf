using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionenshowModel
{
    internal class QuestionList
    {
        private List<Question> questions;
        private Random random = new Random();

        public QuestionList()
        {
            questions = new List<Question>();
        }

        public void Add(Question q)
        {
            questions.Add(q);
        }

        public Question GetRandomQuestion() 
        {
          int idx = random.Next(questions.Count);
          
           return questions[idx];
        }
    }
}
