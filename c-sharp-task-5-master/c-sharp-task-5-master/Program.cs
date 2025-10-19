using System;
using System.Drawing;

namespace assigment_5
{
    internal class Program
    {
        enum WeekDays
        {
            satrday,
            sunday,
            monday,
            thusday,
            wensday,
            thursday,
            friday,
        }
        enum Season
        {
            spring,
            summer,
            autumn,
            winter,
        }
        public static double GetDistance(Point p)
        {
            double distance = 0;
            return Math.Sqrt(Math.Pow((p.X + p.Y), 2) + Math.Pow((p.X - p.Y), 2));
        }
        

        enum Colors
        {
            Red , Green, Blue
        }
        [Flags]
        enum permission
        {
            read = 1, write = 2, delete = 3, excute = 4
        }




        static void Main(string[] args)
        {
            #region problem 01
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{

            //    Console.WriteLine(day);
            //} 
            #endregion

            #region problem 02 
            //Person[] arr = new Person[]
            //    {
            //    new Person(22 , "mohamed"),
            //    new Person(23 , "Ahmed"),
            //    new Person(25 , "ahmed"),


            //    };
            //foreach (Person p in arr)
            //{
            //    Console.WriteLine(p.ToString());

            //} 
            #endregion


            #region problem 03
            //Console.WriteLine("enter the season");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //} 
            #endregion

            permission p = permission.write & permission.delete ;
            Console.WriteLine(p);

            #region problem 05
            //Console.WriteLine("enter the color ");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine("this color is aprimary color");
            //}
            //else
            //{
            //    Console.WriteLine("not a primary color");
            //} 
            #endregion


            #region problem 0 6 

            //Point point = new Point(3, 4);
            //double distant = GetDistance(point);
            //Console.WriteLine(distant); 
            #endregion

            #region problem 0 7 
            //Person[] arr = new Person[3];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the age of the person {i + 1}");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"enter the nwme of the person {i + 1}");
            //    string name = Console.ReadLine();
            //    arr[i] = new Person(age, name);

            //}
            //Person theoldest = arr[0];
            //int oldest = arr[0].Age;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i].Age > oldest)
            //    {
            //        oldest = arr[i].Age;
            //        theoldest = arr[i];
            //    }
            //}
            //Console.WriteLine(theoldest.ToString());
            #endregion





        } 
       
    }
}
