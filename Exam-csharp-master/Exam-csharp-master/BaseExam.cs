using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class BaseExam
    {
        private int Time; 
        public int time { get { return Time;  } set { Time = value; } }

        private int NumberOfQuesition;
        public int numberOfQuesition { get { return NumberOfQuesition; } set { NumberOfQuesition = value; } }

        public List<Question> questions { get; set; }  
        public BaseExam(int _time , int _numofquestion) {
            Time = _time;
            NumberOfQuesition = _numofquestion;
            questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            if (questions.Count < numberOfQuesition)
            {
                questions.Add(question);
            }
            else
            {
                Console.WriteLine($" the number of Question of the exam must be {numberOfQuesition} ");
            }

        }

        public int TotalMarks()
        {
            int total = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                total += questions[i].marks;
            }
            return total;
        }

        public abstract void DisplayExam();
    }
}
