using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape ss = new Square(5);
            ss.calculateArea();
            ss.calculatePerimeter();
            Square sq = new Square();
            sq.squarePrint();

            Shape sr = new Rectangle(4,5);
            sr.calculateArea();
            sr.calculatePerimeter();
            Rectangle r= new Rectangle();
            r.rectPrint();

            Shape sc = new Circle(5);
            sc.calculateArea();
            sc.calculatePerimeter();
            Circle c = new Circle();
            c.circlePrint();
        }
    }
}
