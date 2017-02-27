using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    public static class Command
    {
        

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var commandLine = Console.ReadLine();
            bool isThereValidComand = false;
            
            while (commandLine!="end")
            {
                string[] line = commandLine.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = line[0];
                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(line[2].ToString());
                        int reverseCount = int.Parse(line[4].ToString());
                        var tempListReverse = input.ToList();
                        if (IsValid(input,reverseStart,reverseCount))
                        {
                            var reverseToPrint = string.Join(", ", Reverse(tempListReverse, reverseStart, reverseCount));
                            Console.WriteLine($"[{reverseToPrint}]");
                            isThereValidComand = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                           
                        }
                        break;
                    case "sort":
                        int sortStart = int.Parse(line[2].ToString());
                        int sortCount = int.Parse(line[4].ToString());
                        var tempListSort = input.ToList();
                        if (IsValid(input, sortStart, sortCount))
                        {
                            Sort(tempListSort, sortStart, sortCount);
                            Console.WriteLine("[{0}]",string.Join(", ",input));
                            isThereValidComand = true;
                        }
                        else
                        {
                            
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        int rollLeftCount = int.Parse(line[1].ToString());
                        var tempList = input.ToList();
                        if (rollLeftCount>=0)
                        {
                            var result = RollLeft(tempList, rollLeftCount);
                            Console.WriteLine("[{0}]", string.Join(", ", result));
                            isThereValidComand = true;
                        }
                        else
                        {

                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(line[1].ToString());
                        if (rollRightCount >= 0)
                        {
                            var tempList2 = input.ToList();
                            var rollRightResult = RollRight(tempList2, rollRightCount);
                            Console.WriteLine("[{0}]", string.Join(", ", rollRightResult));
                            isThereValidComand = true;
                        }
                        else
                        {

                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    default:
                        
                        break;
                }
                commandLine = Console.ReadLine();
            }
            if (!isThereValidComand)
            {
                Console.WriteLine("[{0}]", string.Join(", ", input));
            }
        }

        private static List<string> RollRight(List<string> input, int rollRightCount)
        {
            var countOfRotations = rollRightCount;
            var tempArr = input.ToArray();
            if (rollRightCount > input.Count)
            {
                countOfRotations = rollRightCount % input.Count;
            }
            for (int i = 0; i < countOfRotations; i++)
            {
                var lastElem = tempArr[tempArr.Length - 1];
                for (int j = tempArr.Length - 1; j > 0; j--)
                {
                    tempArr[j] = tempArr[j - 1];
                }
                tempArr[0] = lastElem;
            }
            return tempArr.ToList();
        }

        private static List<string> RollLeft(List<string> input, int rollLeftCount)
        {
            var countOfRotations = rollLeftCount;
            var tempArr = input.ToArray();
            if (rollLeftCount > input.Count)
            {
                countOfRotations = rollLeftCount % input.Count;
            }
            for (int i = 0; i < countOfRotations; i++)
            {
                var firstElement = tempArr[0];
                for (int j = 0; j < tempArr.Length-1; j++)
                {
                    tempArr[j] = tempArr[j + 1];
                }
                tempArr[tempArr.Length - 1] = firstElement;
            }
            return tempArr.ToList();
            
        }

        private static void Sort(List<string> input, int sortStart, int sortCount)
        {
            List<string> resultList = input.Skip(sortStart).Take(sortCount).OrderBy(x=>x).ToList();
            input.RemoveRange(sortStart, sortCount);
            input.InsertRange(sortStart, resultList);
        }

        private static List<string> Reverse(List<string> input, int reverseStart, int reverseCount)
        {
            List<string> resultList = input.Skip(reverseStart).Take(reverseCount).Reverse().ToList();
            input.RemoveRange(reverseStart, reverseCount);
            input.InsertRange(reverseStart, resultList);
            return input;
        }
        private static bool IsValid(List<string> array,int start,int count)
        {
            bool isValid = true;
            if ((start<0 || start>array.Count-1))
            {
                
                return false;
            }
            else if (count>=array.Count)
            {
                return false;
            }
            else if (start + count > array.Count)
            {
                return false;
            }
            else if (count<0)
            {
                return false;
            }
            else if (start<0)
            {
                return false;
            }
            else if (start + count <0)
            {
                return false;
            }
            else if (!(start <= array.Count))
            {
                return false;
            }
            return isValid;
        }
    }
}

