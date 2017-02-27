using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetwenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstPoint = Console.ReadLine().Split();
            Point firstPoint = new Point();
            firstPoint.X = double.Parse(inputFirstPoint[0]);
            firstPoint.Y = double.Parse(inputFirstPoint[1]);

            var inputSecondPoint = Console.ReadLine().Split();
            Point secondPoint = new Point();
            secondPoint.X = double.Parse(inputSecondPoint[0]);
            secondPoint.Y = double.Parse(inputSecondPoint[1]);

            Console.WriteLine($"{CalculateDistance(firstPoint,secondPoint):f3}");
            
        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);
            return Math.Sqrt(powX + powY);
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }
}
