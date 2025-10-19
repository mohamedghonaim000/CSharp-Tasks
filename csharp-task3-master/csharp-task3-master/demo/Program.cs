using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //TypeA a1 = new TypeB( 2 , 3 , 4);
            //a1.func01();
            //a1.func02();

            IMovable airplane = new AirPlane();
            airplane.backward();

            IFlyable airplane02 = new AirPlane();
            airplane02.backward();
        }
    }
}
