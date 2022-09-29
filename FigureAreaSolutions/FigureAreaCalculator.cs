using System;

namespace FigureAreaSolutions
{
    // По-хорошему, нужно использовать struct а не class для математических операций, однако я делаю
    // расчет на изменяемость реализации за счет DI, а для DI требуются реализации на ссылочном типе
    public interface ICircleAreaCalculator
    {
        public decimal CalculateCircleArea(decimal radius);
    }

    public interface ITriangleAreaCalculator
    {
        public double CalculateTriangleArea(double a, double b, double c);
    }


    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        public decimal CalculateCircleArea(decimal radius)
        {
            if (radius > 0)
                return (decimal)Math.PI * (radius * radius);
            else
                throw new Exception("Радиус должен быть больше нуля");
        }
    }

    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        public double CalculateTriangleArea(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    var perimeter = (a + b + c) / 2;
                    return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                }
                else
                    throw new Exception("Треугольник с заданными сторонами не существует");
            }
            else
                throw new Exception("Значения всех сторон должны быть больше нуля");
        }
    }
}