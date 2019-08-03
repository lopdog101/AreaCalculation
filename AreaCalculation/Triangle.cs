using System;
using System.Reflection;

namespace AreaCalculation
{
    public class Triangle : ICloneable
    {
        private readonly Point _centerPoint;
        private readonly double _radius;

        public Point CenterPoint
        {
            get { return _centerPoint; }
        }

        public Triangle(Point centerPoint, double radius)
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
            var cloneCircle = new Triangle(_centerPoint, _radius);

            return cloneCircle;
        }

        public static bool operator ==(Triangle left, Triangle right)
        {
            return left.GetHashCode() == right.GetHashCode();
        }

        public static bool operator !=(Triangle left, Triangle right)
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

        public override string ToString()
        {
            return (String.Format("CenterPoint: {0}, Radius: {1}", _centerPoint, _radius));
        }
    }
}
