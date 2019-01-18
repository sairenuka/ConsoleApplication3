using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Shape
    {
        protected int _area;
        protected int _color;
        protected int _perimeter;
        public Shape()
        {

        }
        public Shape(int _area, int _color, int _perimeter)
        {
            this._area = _area;
            this._color = _color;
            this._perimeter = _perimeter;
        }
        public abstract void calculateArea();
        public abstract void calculatePerimeter();
    }
}
