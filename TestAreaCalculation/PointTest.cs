using NUnit.Framework;

namespace AreaCalculationTests
{
    using AreaCalculation;

    [TestFixture]
    public class TestPoint
    {
        [Test]
        public void PointGood()
        {
            var temp = new Point(1, 1);

            Assert.AreEqual(1, temp.X);
            Assert.AreEqual(1, temp.Y);
        }

        [Test]
        public void EqualsGood()
        {
            var temp = new Point(1, 1);
            var tempTwo = new Point(1, 1);

            Assert.True(temp.Equals(tempTwo));
        }

        [Test]
        public void EqualsGoodTwo()
        {
            var temp = new Point(1, 1);
            var tempTwo = new Point(1, 1);

            Assert.True(temp == tempTwo);
        }

        [Test]
        public void EqualsBad()
        {
            var temp = new Point(6, 1);
            var tempTwo = new Point(1, 1);

            Assert.False(temp.Equals(tempTwo));
        }

        [Test]
        public void EqualsBadTwo()
        {
            var temp = new Point(6, 1);
            var tempTwo = new Point(1, 1);

            Assert.True(temp != tempTwo);
        }

        [Test]
        public void EqualsBadThri()
        {
            var temp = new Point(6, 1);
            var tempTwo = new Circle(new Point(3, 4), 6);

            Assert.False(temp.Equals(tempTwo));
        }

        [Test]
        public void EqualsBadFour()
        {
            var temp = new Point(6, 1);
            var tempTwo = new Point(1, 1);

            Assert.False(temp.Equals(tempTwo));
        }

        [Test]
        public void EqualsGoodTri()
        {
            var temp = new Point(1, 1);
            var tempTwo = new Point(1, 1);

            Assert.True(temp.Equals(tempTwo));
        }

        [Test]
        public void EqualsBadFive()
        {
            var temp = new Point(1, 1);
            var tempTwo = new Point();

            Assert.False(temp.Equals(tempTwo));
        }
    }
}