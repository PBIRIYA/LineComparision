using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
namespace LineComparision
{
    class Line
    {
        Point _startPoint = new Point();
        Point _endPoint = new Point();
        double _length;
        public Line(Point StartPoint, Point EndPoint)
        {
            this._startPoint = StartPoint;
            this._endPoint = EndPoint;
        }
        public Point StartPoint { get => _startPoint; set => _endPoint = value; }
        public Point EndPoint { get => _endPoint; set => _endPoint = value; }
        public double Length
        {
            get
            {
                _length = Math.Sqrt(Math.Pow((_endPoint.X - _startPoint.X), 2) + Math.Pow((_endPoint.Y - _startPoint.Y), 2));
                return Math.Round(_length, 3);
            }
        }
    }
}