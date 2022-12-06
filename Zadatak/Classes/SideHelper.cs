using System;

namespace Zadatak.Classes
{
    public static class SideHelper
    {
        public static double GetDistance(double x1, double x2)
        {
            return Math.Abs(x1 - x2);
        }

        public static double GetSide(Point firstPoint, Point secondPoint)
        {
            var distanceX = GetDistance(firstPoint.X, secondPoint.X);
            var distanceY = GetDistance(firstPoint.Y, secondPoint.Y);

            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }
    }
}
