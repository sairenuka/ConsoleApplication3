using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Circle : Shape
    {
        protected int _radius;
        public Circle() { }
        public Circle(int _radius)
        {
            this._radius = _radius;
        }
        public override void calculateArea()
        {
            Console.WriteLine((3 * _radius * _radius));
        }
        public override void calculatePerimeter()
        {
            Console.WriteLine(2 * 3 *(_radius));
        }
        public void circlePrint()
        {
            Console.WriteLine("This is circle");
        }
    }
}
