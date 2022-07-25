namespace Figures.Common
{
    /// <summary>
    /// Circle implementation
    /// </summary>
    public class Circle : IFigure
    {
        public double radius { get; private set; }
        /// <summary>
        /// Initializes the circle
        /// </summary>
        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can not be negative");

            this.radius = radius;
        }

        /// <summary>
        /// Area of the circle
        /// </summary>
        public double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }
}