using System;
using System.Reflection;

namespace AreaCalculation
{
    public class Triangle : ICloneable
    {
        private readonly Point _first;
        private readonly Point _second;
        private readonly Point _third;        
                
        public Triangle(Point first, Point second, Point third)
        {
            _first = first;
            _second = second;
            _third = third;
        }
                
        public double CalculateArea()
        {          
            return 0.5 * Math.Abs((_second.X - _first.X) * (_third.Y - _first.Y) - (_third.X - _first.X) * (_second.Y - _first.Y));
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
            return (_first.GetHashCode() * _second.GetHashCode()) ^ _second.GetHashCode();
        }
                
        public object Clone()
        {
            var cloneTriangle = new Triangle(_first, _second, _third);

            return cloneTriangle;
        }
                
    }
}
