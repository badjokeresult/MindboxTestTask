using Mindbox.Figures;
using System;
using NUnit.Framework;

namespace MindboxTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void NegativeSideTest()
        {
            // Arrange
            Triangle triangle1 = null;
            Triangle triangle2 = null;
            Triangle triangle3 = null;

            // Act
            try
            {
                triangle1 = new Triangle(-1, 2, 3);
            }
            catch (Exception ex)
            {

            }

            try
            {
                triangle2 = new Triangle(1, -2, 3);
            }
            catch (Exception ex)
            {

            }

            try
            {
                triangle3 = new Triangle(1, 2, -3);
            }
            catch(Exception ex)
            {

            }

            // Assert
            Assert.That(triangle1, Is.EqualTo(null));
            Assert.That(triangle2, Is.EqualTo(null));
            Assert.That(triangle3, Is.EqualTo(null));
        }

        [Test]
        public void SumOfTwoSidesTest()
        {
            // Arrange
            Triangle triangle1 = null;
            Triangle triangle2 = null;
            Triangle triangle3 = null;

            // Act
            try
            {
                triangle1 = new Triangle(1, 1, 5);
            }
            catch (Exception e)
            {

            }

            try
            {
                triangle2 = new Triangle(1, 5, 1);
            }
            catch (Exception e)
            {

            }

            try
            {
                triangle3 = new Triangle(5, 1, 1);
            }
            catch (Exception e)
            {

            }

            // Assert
            Assert.That(triangle1, Is.EqualTo(null));
            Assert.That(triangle2, Is.EqualTo(null));
            Assert.That(triangle3, Is.EqualTo(null));

        }

        [Test]
        public void CalculateSquareTest()
        {
            // Arrange
            Triangle triangle1 = new Triangle(1, 2, 3);
            Triangle triangle2 = new Triangle(4, 5, 6);
            Triangle triangle3 = new Triangle(7, 8, 9);

            // Act
            double res1 = triangle1.Square();
            double res2 = triangle2.Square();
            double res3 = triangle3.Square();

            // Assert
            Assert.That(res1, Is.EqualTo(0));
            Assert.That(res2, Is.EqualTo(Math.Sqrt(7.5 * 3.5 * 2.5 * 1.5)));
            Assert.That(res3, Is.EqualTo(Math.Sqrt(12 * 5 * 4 * 3)));
        }

        [Test]
        public void IsRectangleTest()
        {
            // Arrange
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(4, 5, 6);
            Triangle triangle3 = new Triangle(5, 12, 13);

            // Act
            bool res1 = triangle1.IsRectangular();
            bool res2 = triangle2.IsRectangular();
            bool res3 = triangle3.IsRectangular();

            // Assert
            Assert.IsTrue(res1);
            Assert.IsTrue(!res2);
            Assert.IsTrue(res3);
        }

        [Test]
        public void PrintSidesTest()
        {
            // Arrange
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(4, 5, 6);
            Triangle triangle3 = new Triangle(5, 12, 13);

            // Act
            string res1 = triangle1.ToString();
            string res2 = triangle2.ToString();
            string res3 = triangle3.ToString();

            // Assert
            Assert.That(res1, Is.EqualTo("3, 4, 5"));
            Assert.That(res2, Is.EqualTo("4, 5, 6"));
            Assert.That(res3, Is.EqualTo("5, 12, 13"));
        }
    }
}
