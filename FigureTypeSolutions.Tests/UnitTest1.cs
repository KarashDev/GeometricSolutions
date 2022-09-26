namespace FigureTypeSolutions.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        ITriangleTypeQualifier triangleTypeQualifier = new TriangleTypeQualifier();

        [Test]
        public void Right()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expectedResult = TriangleShape.Right;

            Assert.AreEqual(expectedResult, triangleTypeQualifier.DetermineTriangleType(a, b, c));
        }

        [Test]
        public void Acute()
        {
            var a = 12;
            var b = 15;
            var c = 13;
            var expectedResult = TriangleShape.Acute;

            Assert.AreEqual(expectedResult, triangleTypeQualifier.DetermineTriangleType(a, b, c));
        }

        [Test]
        public void Obtuse()
        {
            var a = 12;
            var b = 16;
            var c = 52;
            var expectedResult = TriangleShape.Obtuse;

            Assert.AreEqual(expectedResult, triangleTypeQualifier.DetermineTriangleType(a, b, c));
        }
    }
}