using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthOfField = int.Parse(Console.ReadLine());
            var ladyBugsPos = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var field = new int[lengthOfField];
            for (int i = 0; i < field.Length; i++)
            {
                if (ladyBugsPos.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            var line = Console.ReadLine();
            while (line != "end")
            {
                var info = line.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var startPos = (int.Parse)(info[0].ToString());
                var direction = info[1].ToString();
                var lengthOfMovement = int.Parse(info[2].ToString());

                if (startPos < 0 || startPos >= field.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (field[startPos]==0)
                {
                    line = Console.ReadLine();
                    continue;
                }
                MoveLadyBug(field, startPos, lengthOfMovement,direction);


                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static void MoveLadyBug(int[] field, int startPos, int lengthOfMovement, string direction)
        {
            field[startPos] = 0;

            var leftArrayOrFoundPlace = false;
            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "right":
                        startPos += lengthOfMovement;
                        break;
                    case "left":
                        startPos -= lengthOfMovement;
                        break;

                }
                if (startPos < 0 || startPos >= field.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }
                if (field[startPos]==1)
                {
                    switch (direction)
                    {
                        case "right":
                            startPos += lengthOfMovement;
                            break;
                        case "left":
                            startPos -= lengthOfMovement;
                            break;

                    }
                }
                if (startPos < 0 || startPos >= field.Length)
                {
                    leftArrayOrFoundPlace = true;
                    break;
                }
                if (field[startPos] == 0)
                {
                    field[startPos] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }

        }
    }
}
