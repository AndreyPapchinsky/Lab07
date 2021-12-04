using System;

namespace Lab07
{
    class Triangle
    {
        public double a, b, c;
        public void Insert() // Проинициализировать стороны треугольника;
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
        }
        public double Perimeter() // Расчитать периметр треугольника;
        {
            var Perimeter = (a + b + c);
            return Perimeter;
        }
        public double Square() // Расчитать площадь треугольника;
        {
            var sPerimeter = Perimeter() / 2;
            var Square = Math.Sqrt(sPerimeter * (sPerimeter - a) * (sPerimeter - b) * (sPerimeter - c));
            return Square;
        }
        public void Print() // Вывести длины сторон треугольника на экран;
        {
            Console.WriteLine($"Сторона a = {a}\n Сторона b = {b}\n Сторона c = {c}");
        }
        public bool CheckTriangle() // Реализовать проверку, позволяющую установить, существует ли треугольник с данными длинами сторон;
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
    }
}
