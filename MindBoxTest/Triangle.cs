namespace MindboxTest
{
    /// <summary>
    /// Class for manipulation with triangle shape.
    /// </summary>
    /// <seealso cref="MindboxTest.Shape" />
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
                double sideASquare = this.SideA * this.SideA;
                double sideBSquare = this.SideB * this.SideB;
                double sideCSquare = this.SideC * this.SideC;

                return (sideASquare + sideBSquare == sideCSquare) || (sideASquare + sideCSquare == sideBSquare) || (sideBSquare + sideCSquare == sideASquare);
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
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
            double semiperimeter = this.GetSemiperimeter();
            return Math.Sqrt(semiperimeter * (semiperimeter - this.SideA) * (semiperimeter - this.SideB) * (semiperimeter - this.SideC));
        }

        /// <summary>
        /// Validates this input data for the triangle.
        /// </summary>
        /// <exception cref="System.ArgumentException">
        /// Triangle side should be more than 0
        /// or
        /// Triangle with sides {this.SideA}, {this.SideB} and {this.SideC} can not exist
        /// </exception>
        public override void Validate()
        {
            if (this.SideA <= 0 || this.SideB <= 0 || this.SideC <= 0)
            {
                throw new ArgumentException("Triangle side should be more than 0");
            }

            if (this.IsValidTriangle() == false)
            {
                throw new ArgumentException($"Triangle with sides {this.SideA}, {this.SideB} and {this.SideC} can not exist");
            }
        }

        private double GetSemiperimeter()
        {
            return (this.SideA + this.SideB + this.SideC) / 2;
        }

        private bool IsValidTriangle()
        {
            return ((this.SideA + this.SideB <= this.SideC) || (this.SideA + this.SideC <= this.SideB) || (this.SideB + this.SideC <= this.SideA)) == false;
        }
    }
}
