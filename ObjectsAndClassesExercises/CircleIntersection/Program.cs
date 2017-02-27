using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle firstCircle = new Circle { X = firstInput[0], Y = firstInput[1], R = firstInput[2] };
            var secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle secondCircle = new Circle { X = secondInput[0], Y = secondInput[1], R = secondInput[2] };

            var distance = CalculateDistance(firstCircle, secondCircle);
            var sumOfRadius = firstCircle.R + secondCircle.R;

            if (distance<=sumOfRadius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
        public static double CalculateDistance(Circle firstPoint, Circle secondPoint)
        {
            
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);
            var d = Math.Sqrt(powX + powY);
            return d;
        }
    }

}

