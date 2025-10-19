using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public int C { get; set; }


        public TypeB(int A , int _b , int _c):base(A)
        { 
            B = _b;
            C = _c;
        }

        //public new void func01()
        //{
        //    Console.WriteLine("iam the child class");
        //}

        public override void func01()
        {
            Console.WriteLine("iam the child class");
        }

        public override void func02()
        {
            Console.WriteLine($" iam from child and equal : {B} and {C}");
        }
    }
}
