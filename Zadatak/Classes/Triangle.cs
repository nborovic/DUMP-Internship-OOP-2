using System;

namespace Zadatak.Classes
{
    public class Triangle : Shape
    {
        public double GetCircumference()
        {
            return SideHelper.GetSide(PointA, PointB) + SideHelper.GetSide(PointB, PointC) + SideHelper.GetSide(PointC, PointA);
        }

        public virtual double GetArea()
        {
            Console.WriteLine("Heron formula");

            var halfCircumference = GetCircumference() / 2;

            var area = Math.Sqrt(halfCircumference
                * (halfCircumference - SideHelper.GetSide(PointA, PointB))
                * (halfCircumference - SideHelper.GetSide(PointB, PointC))
                * (halfCircumference - SideHelper.GetSide(PointC, PointA)));

            return area;
        }
    }
}
