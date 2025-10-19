using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_03_oop
{
    internal class Circle : ICircle
    {
        public int Area { get; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("iam acircle");
        }

        public void premeter()
        {
            Console.WriteLine("my premeter is 2*22/7*r");
        }
    }
}
