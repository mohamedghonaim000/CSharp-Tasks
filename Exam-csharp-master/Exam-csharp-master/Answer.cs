using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answer : ICloneable
    {
        private int Id ;  
        public int id { get { return Id; } set { Id = value; } }

        private string Text; 
        public string text
        {
            get { return Text; }
            set { Text = value; }

        }

        public Answer (string _text  , int _id)
        {
            Text = _text;
            Id = _id;
        }
        public override string ToString()
        {
            return $"the answer id  = {id} answer text {text}";
        }

        public object Clone()
        {
            return new Answer (text , id);
        }
    }
}
