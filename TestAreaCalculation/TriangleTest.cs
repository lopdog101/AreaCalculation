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
               

    }
}