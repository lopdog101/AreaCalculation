using System;

namespace AreaCalculation
{
    public class Square : ICloneable
    {
        private readonly Point _topLeftPoint;
        private readonly double _side;

        public Point CenterPoint
        {
            get
            {
                return new Point(_topLeftPoint.X - _side / 2, _topLeftPoint.Y - _side / 2);
            }

        }

        public Square(Point topLeftPoint, double side)
        {
            _topLeftPoint = topLeftPoint;
            _side = side;
        }

        public object Clone()
        {
            var cloneSquare = new Square(_topLeftPoint, _side);

            return cloneSquare;
        }

        public static bool operator ==(Square left, Square right)
        {

            return (left._side == right._side) && (left._topLeftPoint == right._topLeftPoint);
        }

        public static bool operator !=(Square left, Square right)
        {

            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return _topLeftPoint.GetHashCode() ^ _side.GetHashCode();
        }

        public override string ToString()
        {
            return (String.Format("TopLeftPoint: {0}, Side: {1}", _topLeftPoint, _side));
        }


    }
}