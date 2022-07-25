using System;
using NUnit.Framework;
using Figures.Common;

namespace Figures.Test
{
    [TestFixture]
    public sealed class CircleTests
    {

        [Test]
        public void TestArea()
        {
            var circle = new Circle(2);
            if ( Math.Abs(circle.Area - 12.566370) > 0.000001 )
            {
                Assert.Fail("Wrong circle area answer");
            }
            Assert.Pass();
        }
        [Test]
        public void TestNegative()
        {
            try
            {
                var circle = new Circle(-1);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}