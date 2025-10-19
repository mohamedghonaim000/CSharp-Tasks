using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class McqQuestion : Question
    {

        public McqQuestion(string header, string body, int marks)
        : base(header, body, marks)
        {
        }
        public override bool CheckTheCorrectAnswer(Answer useranswer)
        {
            if(useranswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
