using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
        private double x;
        private double y;

        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double DistanceBetweenTwoPoint (Point other)
        {

            return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
        }
    }
}
