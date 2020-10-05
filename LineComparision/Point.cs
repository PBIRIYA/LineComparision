using System;
using System.Collections.Generic;
using System.Text;
namespace LineComparision
{
    class Point
    {
        int _x;
        int _y;
        public Point()
        {
            this._x = 0;
            this._y = 0;
        }
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
    }
}