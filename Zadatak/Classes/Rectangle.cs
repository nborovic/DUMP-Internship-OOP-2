using System;

namespace Zadatak.Classes
{
    public class Rectangle : Shape
    {
        public Point PointD { get; set; }

        public double GetCircumference()
        {
            return 4 * SideHelper.GetSide(PointA, PointB);
        }

        public double GetArea()
        {
            return Math.Pow(SideHelper.GetSide(PointA, PointB), 2);
        }
    }
}
