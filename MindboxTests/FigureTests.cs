using NUnit.Framework;
using System;
using Mindbox;
using Mindbox.Figures;

namespace MindboxTests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void CreateCircleTest()
        {
            // Arrange
            Circle circle = new Circle(3);

            // Act
            Figure figure = new Figure(circle);

            // Assert
            Assert.IsTrue(figure.figure is Circle);
        }

        [Test]
        public void CreateTriangleTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            
            // Act
            Figure figure = new Figure(triangle);

            // Assert
            Assert.IsTrue(figure.figure is Triangle);
        }

        [Test]
        public void CalculateCircleSquareTest()
        {
            // Arrange
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(2);
            Circle circle3 = new Circle(3);

            Figure figure1 = new Figure(circle1);
            Figure figure2 = new Figure(circle2);
            Figure figure3 = new Figure(circle3);

            // Act
            double res1 = figure1.Square();
            double res2 = figure2.Square();
            double res3 = figure3.Square();

            // Assert
            Assert.That(res1, Is.EqualTo(Math.PI));
            Assert.That(res2, Is.EqualTo(Math.PI * 4));
            Assert.That(res3, Is.EqualTo(Math.PI * 9));
        }

        [Test]
        public void CalculateTriangleSquareTest()
        {
            // Arrange
            Triangle triangle1 = new Triangle(1, 2, 3);
            Triangle triangle2 = new Triangle(4, 5, 6);
            Triangle triangle3 = new Triangle(7, 8, 9);

            Figure figure1 = new Figure(triangle1);
            Figure figure2 = new Figure(triangle2);
            Figure figure3 = new Figure(triangle3);

            // Act
            double res1 = figure1.Square();
            double res2 = figure2.Square();
            double res3 = figure3.Square();

            // Assert
            Assert.That(res1, Is.EqualTo(0));
            Assert.That(res2, Is.EqualTo(Math.Sqrt(7.5 * 3.5 * 2.5 * 1.5)));
            Assert.That(res3, Is.EqualTo(Math.Sqrt(12 * 5 * 4 * 3)));
        }

        [Test]
        public void IsRectangularTest()
        {
            // Arrange
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(4, 5, 6);
            Triangle triangle3 = new Triangle(5, 12, 13);
            Circle circle1 = new Circle(5);

            Figure figure1 = new Figure(triangle1);
            Figure figure2 = new Figure(triangle2);
            Figure figure3 = new Figure(triangle3);
            Figure figure4 = new Figure(circle1);

            // Act
            bool res1 = figure1.IsRectangular();
            bool res2 = figure2.IsRectangular();
            bool res3 = figure3.IsRectangular();
            bool res4 = figure4.IsRectangular();

            // Assert
            Assert.IsTrue(res1);
            Assert.IsTrue(!res2);
            Assert.IsTrue(res3);
            Assert.IsTrue(!res4);
        }

        [Test]
        public void PrintFigureTest()
        {
            // Arrange
            Triangle triangle = new Triangle(1, 2, 3);
            Circle circle = new Circle(5);

            Figure figure1 = new Figure(circle);
            Figure figure2 = new Figure(triangle);

            // Act
            string res1 = figure1.ToString();
            string res2 = figure2.ToString();

            // Assert
            Assert.That(res1, Is.EqualTo("5"));
            Assert.That(res2, Is.EqualTo("1, 2, 3"));
        }
    }
}
