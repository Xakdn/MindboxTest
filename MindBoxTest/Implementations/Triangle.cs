namespace MindBoxTest.Implementations
{
    /// <summary>
    /// Class for manipulation with triangle shape.
    /// </summary>
    /// <seealso cref="Shape" />
    public class Triangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        /// <summary>
        /// Gets a value indicating whether this triangle is right.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this triangle is right; otherwise, <c>false</c>.
        /// </value>
        public bool IsRightTriangle
        {
            get
            {
                double sideASquare = SideA * SideA;
                double sideBSquare = SideB * SideB;
                double sideCSquare = SideC * SideC;

                return sideASquare + sideBSquare == sideCSquare || sideASquare + sideCSquare == sideBSquare || sideBSquare + sideCSquare == sideASquare;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            // Ideally, Validate() should be called from client code.
            //this.Validate();
        }

        /// <summary>
        /// Gets the area of the triangle.
        /// </summary>
        /// <returns>
        /// The area.
        /// </returns>
        public override double GetArea()
        {
            double semiperimeter = GetSemiperimeter();
            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        }

        /// <summary>
        /// Validates this input data for the triangle.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Triangle side should be more than 0
        /// or
        /// Triangle with sides {this.SideA}, {this.SideB} and {this.SideC} can not exist
        /// </exception>
        public override void Validate()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Triangle side should be more than 0");
            }

            if (IsValidTriangle() == false)
            {
                throw new ArgumentException($"Triangle with sides {SideA}, {SideB} and {SideC} can not exist");
            }
        }

        private double GetSemiperimeter()
        {
            return (SideA + SideB + SideC) / 2;
        }

        private bool IsValidTriangle()
        {
            return (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA) == false;
        }
    }
}
