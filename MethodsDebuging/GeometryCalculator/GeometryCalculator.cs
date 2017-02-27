using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "triangle":
                    double side =double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    AreaOfTriangle(side, height);
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    AreaOfSquare(sideSquare);
                    break;
                case "rectangle":
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    AreaOfRectangle(length, width);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    AreaOfCircle(radius);
                    break;
            }
        }
        public static void AreaOfTriangle(double side, double height)
        {
            var area = side * height / 2;
            Console.WriteLine("{0:F2}", area);
        }
        public static void AreaOfSquare(double side)
        {
            var area = side*side;
            Console.WriteLine("{0:F2}", area);
        }
        public static void AreaOfRectangle(double length, double width)
        {
            var area = length * width;
            Console.WriteLine("{0:F2}", area);
        }
        public static void AreaOfCircle(double radius)
        {
            var area = Math.PI*radius*radius;
            Console.WriteLine("{0:F2}", area);
        }

    }
}
