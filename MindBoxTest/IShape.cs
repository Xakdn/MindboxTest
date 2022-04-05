namespace MindboxTest
{

    /// <summary>
    /// Interface for manipulation with a shape.
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// Gets the area of the shape.
        /// </summary>
        /// <returns>The area.</returns>
        double GetArea();

        /// <summary>
        /// Validates this input data for the shape.
        /// </summary>
        void Validate();
    }
}
