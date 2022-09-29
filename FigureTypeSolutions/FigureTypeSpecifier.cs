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
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                        return TriangleShape.Right;
                    else if (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2))
                        return TriangleShape.Acute;
                    else
                        return TriangleShape.Obtuse;
                }
                else
                    throw new Exception("Треугольник с заданными сторонами не существует");
            }
            else
                throw new Exception("Значения всех сторон должны быть больше нуля");
        }
    }
}