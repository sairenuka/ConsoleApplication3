using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Rectangle : Shape
    {
        protected int _height;
        protected int _width;
        public Rectangle() { }
        public Rectangle(int _height, int _width)
        {
            this._height = _height;
            this._width = _width;
        }
        public override void calculateArea()
        {
            Console.WriteLine(_height * _width);
        }
        public override void calculatePerimeter()
        {
            Console.WriteLine(2 * (_height+ _width));
        }
        public void rectPrint()
        {
            Console.WriteLine("This is rectangle");
        }
    }
}
