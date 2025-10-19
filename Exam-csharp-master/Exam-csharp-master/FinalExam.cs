using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : BaseExam
    {
        public FinalExam(int time , int numofquestion) :base(time, numofquestion)
        {

        }
        public override void DisplayExam()
        {
            Console.WriteLine("it`s final exammm .. ");
            Console.WriteLine($"total grades {TotalMarks()}");
            Console.WriteLine($"the time : {time}");

            for (int i = 0; i <questions.Count; i++)
            {
                Console.WriteLine($"{questions[i].ToString()}");
                Console.WriteLine($"{questions[i].InputAnswer}");
            }

        }

        public void ShowRightAnswer()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{questions[i].CorrectAnswer}");
            }
        }
    }
}
