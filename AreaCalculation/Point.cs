using System;

namespace AreaCalculation
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.X.Equals(right.X) && left.Y.Equals(right.Y);
        }

        public static bool operator !=(Point left, Point right)
        {

            return !(left == right);
        }

        public bool Equals(Point other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {

            Point p = obj is Point ? (Point)obj : new Point();

            if (p == null)
                return false;
        
            return ((X == p.X) && (Y == p.Y));
        }

        public override string ToString()
        {
            return (String.Format("X: {0}, Y: {1}", X, Y));
        }
    }
}