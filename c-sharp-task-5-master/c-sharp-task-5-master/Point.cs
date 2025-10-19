using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_5
{
    internal struct Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int x, int y) {  X = x; Y = y; }

        //public double GetDistance(int x  , int y) { 
        //     double distance = 0;
        //    return Math.Sqrt(Math.Pow((x + y),2) + Math.Pow((x - y), 2));
        //}
    }
}
