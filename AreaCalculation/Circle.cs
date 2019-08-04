using System;
using System.Reflection;

namespace AreaCalculation
{
    public class Circle : ICloneable
    {
        private readonly Point _centerPoint;
        private readonly double _radius;

        public Point CenterPoint
        {
            get { return _centerPoint; }
        }

        public Circle(Point centerPoint, double radius)
        {
            _centerPoint = centerPoint;
            _radius = radius;
        }

        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }

        public object Clone()
        {
            var cloneCircle = new Circle(_centerPoint, _radius);

            return cloneCircle;
        }

        public static bool operator ==(Circle left, Circle right)
        {
            return left.GetHashCode() == right.GetHashCode();
        }

        public static bool operator !=(Circle left, Circle right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return _centerPoint.GetHashCode() ^ _radius.GetHashCode();
        }               
    }
}
