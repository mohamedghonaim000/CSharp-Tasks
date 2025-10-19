using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class AirPlane : IMovable, IFlyable
    {
        int IMovable.Speed { get; set ; }
        int IFlyable.Speed { get ; set ; }

        void IMovable.backward()
        {
            Console.WriteLine("imove at the ground");
        }

        void IFlyable.backward()
        {
            Console.WriteLine("imove at the air");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("imove at the ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("imove at the air");

        }

        void IMovable.Left()
        {
            Console.WriteLine("imove at the ground");

        }

        void IFlyable.Left()
        {
            Console.WriteLine("imove at the air");

        }

        void IMovable.Right()
        {
            Console.WriteLine("imove at the ground");

        }

        void IFlyable.Right()
        {
            Console.WriteLine("imove at the air");
        }
    }
}
