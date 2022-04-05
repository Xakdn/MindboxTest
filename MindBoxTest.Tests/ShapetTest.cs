namespace MindBoxTest.Tests
{
    using MindboxTest;
    using NUnit.Framework;
    using System;

    public class ShapeTests
    {
        [Test(Description = "Check that circle area is calculated successfully with valid input data.")]
        [TestCase(10, 314.15927)]
        [TestCase(5.5, 95.03318)]
        public void GetCircleAreaWithValidData(double radius, double expectedArea)
        {
            // Arrange.
            Shape circle = new Circle(radius);

            // Act.
            // Round result to 5 number of fractional digits. 
            double actualArea = Math.Round(circle.GetArea(), 5, MidpointRounding.AwayFromZero);

            // Assert.
            Assert.AreEqual(actualArea, expectedArea);
        }

        [Test(Description = "Check that triangle area is calculated successfully with valid input data.")]
        [TestCase(10, 8, 5, 19.81004)]
        [TestCase(20.5, 10, 15.5, 74.87490)]
        public void GetTriangleAreaWithValidData(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange.
            Shape triangle = new Triangle(sideA, sideB, sideC);

            // Act.
            // Round result to 5 number of fractional digits. 
            double actualArea = Math.Round(triangle.GetArea(), 5, MidpointRounding.AwayFromZero);

            // Assert.
            Assert.AreEqual(actualArea, expectedArea);
        }

        [Test(Description = "Check that exception is thrown on circle validation with invalid input data.")]
        [TestCase(-1)]
        [TestCase(0)]
        public void CheckCircleValidation(double radius)
        {
            Shape circle = new Circle(radius);

            // Act.
            // Assert.
            Assert.Throws<ArgumentException>(() => circle.Validate(), "Radius should be more than 0");
        }

        [Test(Description = "Check that exception is thrown on triangle validation with invalid input data.")]
        [TestCase(0, 1, 1, "Triangle side should be more than 0")]
        [TestCase(1, 0, 1, "Triangle side should be more than 0")]
        [TestCase(1, 1, 0, "Triangle side should be more than 0")]
        [TestCase(-1, -1, -1, "Triangle side should be more than 0")]
        [TestCase(10, 1, 1, "Triangle with sides 10, 1 and 1 can not exist")]
        [TestCase(1, 10, 1, "Triangle with sides 1, 10 and 1 can not exist")]
        [TestCase(1, 1, 10, "Triangle with sides 1, 1 and 10 can not exist")]
        public void CheckTriangleValidation(double sideA, double sideB, double sideC, string expectedExceptionMessage)
        {
            // Arrange.
            Shape triangle = new Triangle(sideA, sideB, sideC);

            // Act.
            // Assert.
            Assert.Throws<ArgumentException>(() => triangle.Validate(), expectedExceptionMessage);
        }

        [Test(Description = "Check that triangle is right.")]
        [TestCase(5, 4, 3, true)]
        [TestCase(10, 5, 8, false)]
        public void CheckTriangleIsRight(double sideA, double sideB, double sideC, bool isRight)
        {
            // Arrange.
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act.
            // Assert.
            Assert.AreEqual(triangle.IsRightTriangle, isRight);
        }
    }
}