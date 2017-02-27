using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string neededCalculation = Console.ReadLine().ToLower();
            switch (neededCalculation)
            {
                case "face": FaceOfCube(sideOfCube);break;
                case "space": SpaceOfCube(sideOfCube); break;
                case "volume": VolumeOfCube(sideOfCube); break;
                case "area":AreaOfCube(sideOfCube); break;
            }
        }
        public static void FaceOfCube(double side)
        {
            double face = Math.Sqrt(2 * side * side);
            Console.WriteLine("{0:F2}",face);
        }
        public static void SpaceOfCube(double side)
        {
            double space = Math.Sqrt(3 * side * side);
            Console.WriteLine("{0:F2}", space);
        }
        public static void VolumeOfCube(double side)
        {
            double volume = side * side * side;
            Console.WriteLine("{0:F2}", volume);
        }
        public static void AreaOfCube(double side)
        {
            double area = 6 * (side * side);
            Console.WriteLine("{0:F2}", area);
        }
    }
}