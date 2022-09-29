using System.Security.Cryptography;

namespace FigureAreaSolutions.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        ICircleAreaCalculator circleAreaCalculator = new CircleAreaCalculator();
        ITriangleAreaCalculator triangleAreaCalculator = new TriangleAreaCalculator();

        [Test]
        public void CircleAreaWithoutRound()
        {
            var radius = 50;
            var expectedResult = 7853.981633974475m;

            Assert.AreEqual(expectedResult, circleAreaCalculator.CalculateCircleArea(radius));
        }

        [Test]
        public void CircleAreaWithRound()
        {
            var radius = 6;
            var expectedResult = 113;

            Assert.AreEqual(expectedResult, Math.Round(circleAreaCalculator.CalculateCircleArea(radius)));
        }

        [Test]
        public void EmptyInputRadius()
        {
            var radius = 0;

            var ex = Assert.Throws<Exception>(() => circleAreaCalculator.CalculateCircleArea(radius));
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля"));
        }



        [Test]
        public void TriangleAreaSimpleTest1()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expectedResult = 6;

            Assert.AreEqual(expectedResult, triangleAreaCalculator.CalculateTriangleArea(a, b, c));
        }

        [Test]
        public void TriangleAreaSimpleTest2()
        {
            var a = 13;
            var b = 14;
            var c = 15;
            var expectedResult = 84;

            Assert.AreEqual(expectedResult, triangleAreaCalculator.CalculateTriangleArea(a, b, c));
        }

        [Test]
        public void InputImpossibleSides()
        {
            var a = 3;
            var b = 4;
            var c = 10;

            var ex = Assert.Throws<Exception>(() => triangleAreaCalculator.CalculateTriangleArea(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("Треугольник с заданными сторонами не существует"));
        }

        [Test]
        public void InputEmptySides()
        {
            var a = 0;
            var b = 0;
            var c = 5;

            var ex = Assert.Throws<Exception>(() => triangleAreaCalculator.CalculateTriangleArea(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("Значения всех сторон должны быть больше нуля"));
        }
    }
}