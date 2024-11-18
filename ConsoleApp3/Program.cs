using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static double F(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static double P(double a, double b, double c)
        {
            return a + b + c;
        }
        static double S(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины (x1, y1): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины (x2, y2): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины (x3, y3): ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double a = F(x1, y1, x2, y2);
            double b = F(x2, y2, x3, y3);
            double c = F(x3, y3, x1, y1);
            double perimeter = P(a, b, c);
            double area = S(a, b, c);
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.WriteLine($"Площадь треугольника: {area}");
            Console.ReadKey();  
        }
    }
}
