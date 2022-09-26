using System;

namespace FigureAreaSolutions
{
    // По-хорошему, нужно использовать struct а не class для математических операций, однако я делаю
    // расчет на изменяемость реализации за счет DI, а для DI требуются реализации на ссылочном типе
    public interface ICircleAreaCalculator
    {
        public double CalculateCircleArea(double radius);
    }

    public interface ITriangleAreaCalculator
    {
        public double CalculateTriangleArea(double a, double b, double c);
    }


    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        public double CalculateTriangleArea(double a, double b, double c)
        {
            var perimeter = (a + b + c) / 2;

            return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        }
    }
}