using System;
using NUnit.Framework;

namespace AreaCalculationTests
{
    using AreaCalculation;

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void ToStringTest()
        {
            var circle = new Circle(new Point(3, 4), 6);
            var str = circle.ToString();
            Assert.AreEqual("CenterPoint: X: 3, Y: 4, Radius: 6", str);
        }

        [Test]
        public void GetHashTest()
        {
            var circle = new Circle(new Point(3, 4), 6);

            var temp = circle.GetHashCode();
            Console.WriteLine(temp);
            Assert.AreEqual(1281359872, temp);
        }

        [Test]
        public void GoodEquals()
        {
            var circleOne = new Circle(new Point(3, 4), 6);
            var circleTwo = new Circle(new Point(3, 4), 6);

            Assert.True(circleOne.Equals(circleTwo));

        }

        [Test]
        public void BadEquals()
        {
            var circleOne = new Square(new Point(3, 7), 8);
            var circleTwo = new Circle(new Point(3, 4), 6);

            Assert.False(circleOne.Equals(circleTwo));

        }

        [Test]
        public void BadEqualsTwo()
        {
            var circleOne = new Circle(new Point(3, 7), 8);
            var circleTwo = new Circle(new Point(3, 4), 6);

            Assert.False(circleOne.Equals(circleTwo));
        }

        [Test]
        public void BadEqualsTri()
        {
            var circleOne = new Circle(new Point(3, 7), 8);
            var circleTwo = new Circle(new Point(3, 4), 6);

            Assert.True(circleOne != circleTwo);
        }

        [Test]
        public void GoodEqualsTri()
        {
            var circleOne = new Circle(new Point(3, 4), 6);
            var circleTwo = new Circle(new Point(3, 4), 6);

            Assert.True(circleOne == circleTwo);
        }

        [Test]
        public void CloneTest()
        {
            var circleOne = new Circle(new Point(3, 7), 8);
            var circleTwo = circleOne.Clone();

            Assert.True(circleOne.Equals(circleTwo));
        }

        [Test]
        public void GetCentrePoint()
        {
            var circleOne = new Circle(new Point(3, 4), 6);
            Console.WriteLine(circleOne.CenterPoint);
        }

        [Test]
        public void CalculateAreaCircle()
        {
            var circleOne = new Circle(new Point(3, 4), 6);
            Assert.AreEqual(6 * 6 * Math.PI, circleOne.CalculateArea());            
        }

    }
}