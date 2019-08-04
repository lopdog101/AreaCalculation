using System;
using NUnit.Framework;

namespace AreaCalculationTests
{
    using AreaCalculation;

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ToStringTest()
        {
            var a = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));

            Console.WriteLine(a.CalculateArea());

        }

        [Test]
        public void GetHashTest()
        {
            var triangle = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));

            var temp = triangle.GetHashCode();
            Console.WriteLine(temp);
            Assert.AreEqual(1799356416, temp);
        }

        [Test]
        public void GoodEquals()
        {
            var triangleOne = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));
            var triangleTwo = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));

            Assert.True(triangleOne.Equals(triangleTwo));

        }

        [Test]
        public void BadEquals()
        {
            var triangleOne = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));
            var triangleTwo = new Triangle(new Point(1, -3), new Point(3, -4), new Point(5, -5));

            Assert.False(triangleOne.Equals(triangleTwo));
        }

        [Test]
        public void CloneTest()
        {
            var triangleOne = new Triangle(new Point(-1, -3), new Point(3, 4), new Point(5, -5));
            var triangleTwo = triangleOne.Clone();

            Assert.True(triangleOne.Equals(triangleTwo));
        }
    }
}