using System.Collections.Generic;
using NUnit.Framework;
using Figures.Common;

namespace Figures.Tests
{
    [TestFixture]
    public sealed class FigureTests
    {
        [Test]
        public void TestAreaSet()
        {
            var figuresSet = new List<IFigure>();
            figuresSet.Add(new Circle(1));
            figuresSet.Add(new Triangle(1, 1, 1));
            foreach(var figure in figuresSet)
            {
                var test = figure.Area;
            }
            Assert.Pass();
        }       

    }
}
