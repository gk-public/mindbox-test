
namespace Figures.Common
{
    /// <summary>
    /// Triangle implementation
    /// </summary>
    public class Triangle : IFigure
    {
        public double[] lengths { get; private set; }

        /// <summary>
        /// Initializes the triangle
        /// </summary>
        /// <param name="length1">Lenght of side A</param>
        /// <param name="length2">Lenght of side B</param>
        /// <param name="length3">Lenght of side C</param>
        public Triangle(double length1, double length2, double length3)
        {
            if (length1 <= 0 || length2 <= 0 || length3 <= 0)
                throw new ArgumentException("Length must be greater than 0");

            this.lengths = new double[] { length1, length2, length3 };

            //since the order is not important, sorting once on the initialization for the rightness test
            Array.Sort(this.lengths);
        }

        /// <summary>
        /// Initializes the triangle
        /// </summary>
        /// <param name="lenghts">Array of sides lengths (3 elements)</param>
        public Triangle(double[] lenghts)
        {
            if (lenghts.Length != 3)
                throw new ArgumentException("Array must contain exactly 3 values");

            if (lenghts.Any(x => x <= 0))
                throw new ArgumentException("Length must be greater than 0");

            this.lengths = lenghts;

            //since the order is not important, sorting once on the initialization for the rightness test
            Array.Sort(this.lengths);
        }

        /// <summary>
        /// Area of the triangle
        /// </summary>
        public double Area
        {
            get
            {
                double halfP = (this.lengths[0] + this.lengths[1] + this.lengths[2]) / 2;
                return Math.Sqrt(halfP * (halfP - this.lengths[0]) * (halfP - this.lengths[1]) * (halfP - this.lengths[2]));
            }
        }

        /// <summary>
        /// True if the triangle is right-cornored
        /// </summary>
        public bool isRight
        {
            get
            {
                return this.lengths[0] * this.lengths[0] + this.lengths[1] * this.lengths[1] == this.lengths[2] * this.lengths[2];
            }
        }
    }
}
