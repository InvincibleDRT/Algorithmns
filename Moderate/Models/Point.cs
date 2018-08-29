using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Models
{
    class Point
    {
        public double xCorr { get; set; }
        public double yCorr { get; set; }

        public Point(double xc, double yc)
        {
            xCorr = xc;
            yCorr = yc;
        }
    }
}
