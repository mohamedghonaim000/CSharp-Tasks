using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {
        private string Header; 
        public string header { get { return header;  } set { header = value; } }

        private string Body; 
        public string body { get { return Body; } set { Body = value;  } }

        private int Marks; 
         public int marks { get { return Marks; } set { Marks = value;  } }

        public List<Answer> InputAnswer {  get; set; }
        public Answer CorrectAnswer { get; set; }

       

        //
        //
        public Question(string _header , string _body , int _marks) { 
            Header = _header;
            Body = _body;
            Marks = _marks;
            InputAnswer = new List<Answer>();
        }

        public void AddAnswer(Answer answer) { 
            InputAnswer.Add(answer);
        }

        public void SetcorrectAnswer(Answer answer) {
            if (InputAnswer.Contains(answer))
            {
                CorrectAnswer = answer;
            }
            else {
                Console.WriteLine("this answer dosent exsist in the answers");
            }
        
        }
        public void removeAnswe(Answer answer) { 
            InputAnswer.Remove(answer);
        }

        public abstract bool CheckTheCorrectAnswer(Answer useranswer);

    }
}
