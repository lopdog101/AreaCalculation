using System;
using NUnit.Framework;

namespace AreaCalculationTests
{
    using AreaCalculation;

    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void ToStringTest()
        {
            var square = new Square(new Point(3, 4), 6);
            var str = square.ToString();
            Assert.AreEqual("TopLeftPoint: X: 3, Y: 4, Side: 6", str);
        }

        [Test]
        public void GetHashCodeTest()
        {
            var square = new Square(new Point(3, 4), 6);
            var squareTwo = new Square(new Point(3, 4), 6);

            Assert.AreEqual(squareTwo.GetHashCode(), square.GetHashCode());
        }

        [Test]
        public void EqualsGood()
        {
            var square = new Square(new Point(3, 4), 6);
            var squareTwo = new Square(new Point(3, 4), 6);

            Assert.True(squareTwo.Equals(square));
        }

        [Test]
        public void EqualsGoodTwo()
        {
            var square = new Square(new Point(3, 4), 6);
            var squareTwo = new Square(new Point(3, 4), 6);

            Assert.True(squareTwo == square);
        }

        [Test]
        public void EqualsGoodTri()
        {
            var square = new Square(new Point(3, 4), 6);
            var squareTwo = new Square(new Point(3, 6), 6);

            Assert.True(squareTwo != square);
        }

        [Test]
        public void Centre()
        {
            var square = new Square(new Point(3, 4), 6);

            Console.WriteLine(square.CenterPoint);
        }

        [Test]
        public void Clone()
        {
            var square = new Square(new Point(3, 4), 6);
            var squareTwo = square.Clone();

            Assert.True(!ReferenceEquals(squareTwo, square));
        }

    }
}