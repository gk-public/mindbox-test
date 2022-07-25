using System;
using NUnit.Framework;
using Figures.Common;

namespace Figures.Tests
{
    [TestFixture]
    public sealed class TriangleTests
    {
        [Test]
        public void TestArea()
        {
            var triangle = new Triangle(2,3,4);
            if (Math.Abs(triangle.Area - 2.904737) > 0.000001)
            {
                Assert.Fail("Wrong triangle area answer");
            }
            Assert.Pass();
        }

        [Test]
        public void TestNegativeLen()
        {
            var lenSet = new double[] { 3, -1, 2 };
            try
            {
                var triangle = new Triangle(lenSet);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void TestZeroLen()
        {
            try
            {
                var triangle = new Triangle(2, 1, 0);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void TestWrongNumberOfElements()
        {
            var lenSet1 = new double[] { 3, -1};
            var lenSet2 = new double[] { 3, -1, 1, 1};
            bool isLessPath = false;
            try
            {
                var triangle = new Triangle(lenSet1);
            }
            catch
            {
                isLessPath = true;
            }

            if (!isLessPath)
                Assert.Fail();

            try
            {
                var triangle = new Triangle(lenSet2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void TestIsRigth()
        {

            var triangle1 = new Triangle(5, 4, 3);
            var triangle2 = new Triangle(1, 2, 3);
            if (triangle1.isRight && !triangle2.isRight)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
