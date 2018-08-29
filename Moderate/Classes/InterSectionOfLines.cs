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
            LineSegment line1 = new LineSegment(new Point(1, 2), new Point(4, 4));

            LineSegment line2 = new LineSegment(new Point(0,0), new Point(10, 0));
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
    }
}
