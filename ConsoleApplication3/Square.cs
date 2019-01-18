using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Square : Shape
    {
        protected int _side;
        public Square() { }
        public Square(int _side)
        {
            this._side = _side;
        }
        public override void calculateArea()
        {
             Console.WriteLine(_side * _side);
        }
        public override void calculatePerimeter()
        {
            Console.WriteLine( _side *4);
        }
        public void squarePrint()
        {
            Console.WriteLine("This is square");
        }
    }
}
