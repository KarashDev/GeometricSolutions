namespace FigureTypeSolutions
{
    public interface ITriangleTypeQualifier
    {
        public TriangleShape DetermineTriangleType(int a, int b, int c);
    }

    public class TriangleTypeQualifier : ITriangleTypeQualifier
    {
        public TriangleShape DetermineTriangleType(int a, int b, int c)
        {
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                return TriangleShape.Right;
            else if (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2))
                return TriangleShape.Acute;
            else
                return TriangleShape.Obtuse;
        }
    }
}