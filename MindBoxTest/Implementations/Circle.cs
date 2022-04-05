namespace MindBoxTest.Implementations
{
    /// <summary>
    /// Class for manipulation with circle shape.
    /// </summary>
    /// <seealso cref="Shape" />
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            // Ideally, Validate() should be called from client code.
            // this.Validate();
        }

        /// <summary>
        /// Gets the area of the circle.
        /// </summary>
        /// <returns>
        /// The area.
        /// </returns>
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Validates this input data for the circle.
        /// </summary>
        /// <exception cref="ArgumentException">Radius should be more than 0</exception>
        public override void Validate()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Radius should be more than 0");
            }
        }
    }
}
