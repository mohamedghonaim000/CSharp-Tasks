using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int _a) { A = _a; }

        public virtual void func01()
        {
            Console.WriteLine("iam the base class");
        }

        public virtual void func02()
        {
            Console.WriteLine($" iam from base and equal : {A}");
        }
    }
}
