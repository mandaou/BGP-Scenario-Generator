using System;
using System.Collections.Generic;
using System.Text;

namespace org.squ.md.gen.BusinessObjects
{
   public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceToZero {get;}
        public double AreaBelow { get; }

        public Coordinate(double x, double y)
        {
            this.X = x;
            this.Y = y;

            DistanceToZero = Math.Sqrt(Math.Pow(Y, 2) + Math.Pow(X, 2));
            AreaBelow = 0.5 * X * Y;

        }

        public double DistanceTo(Coordinate c)
        {
            return Math.Sqrt(Math.Pow((c.Y - Y), 2) + Math.Pow((c.X - X), 2));
        }
    }
}

