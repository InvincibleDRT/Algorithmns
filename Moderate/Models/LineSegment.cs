using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Models
{
    class LineSegment
    {
        public  Point startingPoint { get; set; }
        public  Point endPoint { get; set; }

        public LineSegment(Point p1, Point p2)
        {
            startingPoint = p1;
            endPoint = p2;
        }

        public double Slope
        {
            get { return ((endPoint.yCorr - startingPoint.yCorr) / (endPoint.xCorr - startingPoint.xCorr)); }
        }


        public double GetLineSlopeWrtPoint(Point testPoint)
        {
            return ((endPoint.yCorr - testPoint.yCorr) / (endPoint.xCorr - testPoint.xCorr));
        }

        public double ConstantForLine
        {
            get {if (double.IsInfinity(Slope))
                    return startingPoint.xCorr;
                return startingPoint.yCorr - (Slope * startingPoint.xCorr); }
        }
    }
}
