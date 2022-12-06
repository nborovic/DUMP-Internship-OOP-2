using System;

namespace Zadatak.Classes
{
    public class RightTriangle : Triangle
    {  
        public override double GetArea()
        {
            Console.WriteLine("Right triangle formula");

            return SideHelper.GetSide(PointA, PointB) * SideHelper.GetSide(PointB, PointC) / 2;
        }
    }
}
