using System;

namespace assigment_03_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 : a) To provide a way to implement multiple inheritance

            // Q2 : a) private  protected internal

            //Q3 : a) Yes

            // Q4 : b) Yes, interfaces can inherit from multiple interfaces

            // Q5 : d) implements

            // Q6 : b) No

            // Q7 : b) No, all members are implicitly public

            // Q8 : b) To provide a clear separation between interface and class members

            // Q9 : b) No, interfaces cannot have constructors

            // Q10 : c) By separating interface names with commas

            Rectangle r1 = new Rectangle();

            r1.DisplayShapeInfo();

            Circle c1 = new Circle();   
            c1.DisplayShapeInfo();


        }
    }
}
