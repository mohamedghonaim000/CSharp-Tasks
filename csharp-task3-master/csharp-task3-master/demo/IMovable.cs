using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal interface IMovable
    {
        public int Speed { get; set; }

        void Forward ();
        void backward();
        void Left();

        void Right();

    }
}
