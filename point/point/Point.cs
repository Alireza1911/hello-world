using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    public class Point
    {
        #region************************************consttructor*******************
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        #region***************************property*****************
        public double X { get; set; }
        public double Y { get; set; }
        #endregion

        #region*******************************metod*********************
        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
        public double Fasele(double x, double y)
        {
            return Math.Sqrt(Math.Pow((this.X - x), 2) + Math.Pow((this.Y - y), 2));
        }
        public double Fasele(Point another)
        {
            return Math.Sqrt(Math.Pow((this.X - another.X), 2) + Math.Pow((this.Y - another.Y), 2));
        }
        #endregion
    }
}
