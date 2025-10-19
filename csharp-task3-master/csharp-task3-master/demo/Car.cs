
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Car:IMovable
    {
        public int Speed {  get; set; }

        public void Forward()
        {
            Console.WriteLine("iam acar going forward");
        }

        public void backward()
        {
            Console.WriteLine("iam acar going backward");

        }

        public void Left()
        {
            Console.WriteLine("iam acar going left");

        }

        public void Right()
        {
            Console.WriteLine("iam acar going fprward");
            
        }
    }
}
