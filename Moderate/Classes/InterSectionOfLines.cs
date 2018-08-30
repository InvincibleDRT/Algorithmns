using Moderate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Classes
{
    class InterSectionOfLines
    {
        public static Point GetInserction()
        {
            Console.WriteLine("             FirstLine             ");

            LineSegment line1 = CreateLine();

            Console.WriteLine("             SecondLIne            ");

            LineSegment line2 =CreateLine();
            if (line1.Slope == line2.Slope)
            {
                Console.WriteLine("Lines are Parallel. There is no intersection point");
                return null;
            }
            else
            {

                double xCorr;
                if (double.IsInfinity(line1.Slope))
                    xCorr = line1.ConstantForLine;
                else if (double.IsInfinity(line2.Slope))
                    xCorr = line2.ConstantForLine;
                else
                    xCorr = (line1.ConstantForLine - line2.ConstantForLine) / (line2.Slope - line1.Slope);
                double yCorr = (line1.Slope * (xCorr)) + line1.ConstantForLine;
                Console.WriteLine($"X-Coordinate for Intersection is {xCorr} and Y-Coordinate is {yCorr}");
                Console.ReadLine();
                return new Point(xCorr, yCorr);
            }
        }

        private static LineSegment CreateLine()
        {
            Console.WriteLine("Enter a starting Point");
            var p1 = CreatePoint();
            Console.WriteLine("Enter an EndingPoint");            
            var p2 = CreatePoint();
            return new LineSegment(p1,p2);
        }


        private static Point CreatePoint()
        {
            Console.WriteLine("Enter a Point (Ordinates Seperated by Comma e.g. 1,2 )");
            var p = Console.ReadLine();
            return new Point(int.Parse(p.Split(',')[0].Trim()), int.Parse(p.Split(',')[1].Trim()));
        }
    }
}
