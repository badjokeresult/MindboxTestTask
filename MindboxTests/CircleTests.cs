using NUnit.Framework;
using Mindbox.Figures;
using System;

namespace MindboxTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void NegativeRadiusTest()
        {
            // Arrange
            Circle circle = null;

            // Act
            try
            {
                circle = new Circle(-1);
            }
            catch (Exception ex)
            {

            }

            // Assert
            Assert.That(circle, Is.EqualTo(null));
        }

        [Test]
        public void CalculateSquareTest()
        {
            // Arrange
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(2);
            Circle circle3 = new Circle(3);

            // Act
            double res1 = circle1.Square();
            double res2 = circle2.Square();
            double res3 = circle3.Square();

            // Assert
            Assert.That(res1, Is.EqualTo(Math.PI));
            Assert.That(res2, Is.EqualTo(Math.PI * 4));
            Assert.That(res3, Is.EqualTo(Math.PI * 9));
        }

        [Test]
        public void PrintRadiusTest()
        {
            // Arrange
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(2);
            Circle circle3 = new Circle(3);

            // Act
            string res1 = circle1.ToString();
            string res2 = circle2.ToString();
            string res3 = circle3.ToString();

            // Assert
            Assert.That(res1, Is.EqualTo("1"));
            Assert.That(res2, Is.EqualTo("2"));
            Assert.That(res3, Is.EqualTo("3"));
        }
    }
}