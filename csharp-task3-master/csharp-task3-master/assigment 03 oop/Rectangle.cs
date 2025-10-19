using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_03_oop
{
    internal class Rectangle:IRectangle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("iam aRectangle");
        }

        public void premeter()
        {
            Console.WriteLine("my premeter is (l+w) *2");
        }
    }
}
