using MindBoxTest.Interfaces;

namespace MindBoxTest.Implementations
{
    /// <summary>
    /// Abstract class for shapes.
    /// </summary>
    /// <seealso cref="IShape" />
    public abstract class Shape : IShape
    {
        /// <summary>
        /// Gets the area of the shape.
        /// </summary>
        /// <returns>
        /// The area.
        /// </returns>
        public abstract double GetArea();

        /// <summary>
        /// Validates this input data for the shape.
        /// </summary>
        public abstract void Validate();
    }
}
