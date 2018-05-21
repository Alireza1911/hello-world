using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    public class Line
    {
        #region****************constructor****************
        public Line(Point a,Point b)
        {
            this.Point1 = a;
            this.Point2 = b;
        }
        #endregion

        #region*****************************property************************
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        #endregion

        #region**************************metod************************
        public double Shib(double ax, double ay, double bx, double by)
        {
            double m = (ay - by) / (ax - bx);
            return m;
        }
        public void moadele(double x, double y,double m)
        {
            Console.WriteLine("moadele ke shamel in 2 noghte ast barabar ast ba:\t\t\t\t");
            Console.Write("y={0}x-{1}\n",m,(m*x)-y);
        }
        #endregion
    }
}
