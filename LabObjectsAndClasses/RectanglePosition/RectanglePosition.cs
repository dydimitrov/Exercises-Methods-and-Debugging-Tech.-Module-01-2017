using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            var inputRectangleOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle firstRect = new Rectangle
            {
                Left = inputRectangleOne[0],
                Top = inputRectangleOne[1],
                Width = inputRectangleOne[2],
                Height = inputRectangleOne[3]
            };
            var inputRectangleTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle secondRect = new Rectangle
            {
                Left = inputRectangleTwo[0],
                Top = inputRectangleTwo[1],
                Width = inputRectangleTwo[2],
                Height = inputRectangleTwo[3]
            };
            if (IsInside(firstRect,secondRect))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        public static bool IsInside (Rectangle r1, Rectangle r2)
        {
            bool isInsiade = false;
            if (r1.Left>=r2.Left && r1.Right <= r2.Right && r1.Top <= r2.Top && r1.Bottom <= r2.Bottom)
            {
                isInsiade = true;
            }
            return isInsiade;
        }
    }
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom => Top + Width;
        public int Right => Bottom + Height;
    }
}
