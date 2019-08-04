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

        private double CalculatePair(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        public bool CheckRightTriangle()
        {

            double[] triangleSide = new double [3] { CalculatePair(_first, _second), CalculatePair(_first, _third), CalculatePair(_second, _third)};

            Console.WriteLine(triangleSide);

            Array.Sort(triangleSide);

            if (triangleSide[2] * triangleSide[2] == triangleSide[0] * triangleSide[0] + triangleSide[1] * triangleSide[1])
                return true;

            return false;
        }

    }
}
