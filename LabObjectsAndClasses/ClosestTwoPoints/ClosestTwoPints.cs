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
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();
                points.Add(new Point{X = currentPoint[0], Y= currentPoint[1]});

            }
            double closeDistance=double.MaxValue;
            Point bestPoint = null;
            Point secondBestPoint = null;
            for (int i = 0; i < points.Count-1; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var distance = CalculateDistance(firstPoint, secondPoint);
                    if (distance<closeDistance)
                    {
                        closeDistance = distance;
                        bestPoint = firstPoint;
                        secondBestPoint = secondPoint;
                    }

                }
            }
            Console.WriteLine($"{closeDistance:F3}");
            Console.WriteLine($"({bestPoint.X}, {bestPoint.Y})");
            Console.WriteLine($"({secondBestPoint.X}, {secondBestPoint.Y})");
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

