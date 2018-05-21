using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toole noghte aval ra vared konid");
            double ax = int.Parse(Console.ReadLine());
            Console.WriteLine("arze noghte aval ra vared konid");
            double ay = int.Parse(Console.ReadLine());
            Point a = new Point(ax, ay);
            Console.WriteLine("toole noghte dovom ra vared konid");
            double bx = int.Parse(Console.ReadLine());
            Console.WriteLine("arze noghte dovom ra vared konid");
            double by = int.Parse(Console.ReadLine());
            Point b = new Point(bx, by);
            Line c = new Line(a, b);
            double m = c.Shib(ax, ay, bx, by);
            c.moadele(ax, ay, m);
            Console.WriteLine("shibe moadele={0}", m);
            Console.ReadKey();
        }
    }
}
