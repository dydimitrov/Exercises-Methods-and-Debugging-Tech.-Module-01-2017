using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            var commandLine =Console.ReadLine();
            while (commandLine!="end")
            {
                var command = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "exchange":
                        if (IsValid(inputArray,int.Parse(command[1])))
                        {
                            inputArray = Exchange(inputArray, int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":Max(inputArray, command[1]);
                        break;
                    case "min":Min(inputArray, command[1]);
                        break;
                    case "first":First(inputArray, int.Parse(command[1]), command[2]);
                        break;
                    case "last": Last(inputArray, int.Parse(command[1]), command[2]);
                        break;


                    default:
                        break;
                }
                commandLine =Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",inputArray)}]");
        }
        private static void Last(int[] inputArray, int count, string secondFilter)
        {
            var tempList = inputArray.Reverse().ToList();
            var resultList = new List<int>();
            if (secondFilter == "even")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i]%2==0)
                    {
                        resultList.Add(inputArray[i]);
                    }
                }
                if (!resultList.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", tempList.Take(count))}]");
                }
            }
            else if (secondFilter == "odd")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2!= 0)
                    {
                        resultList.Add(inputArray[i]);
                    }
                }
                if (!resultList.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", tempList.Take(count))}]");
                }
            }
        }

        private static void First(int[] inputArray, int count, string secondFilter)
        {
            var tempList = inputArray.ToList();
            if (secondFilter == "even")
            {
                if (count>tempList.Count)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i]%2==0)
                    {
                        tempList.Add(inputArray[i]);
                    }
                }
                if (tempList.Any())
                {
                    Console.WriteLine($"[{string.Join(", ", tempList.Take(count))}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else if (secondFilter == "odd")
            {
                var temList = new List<int>();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 != 0)
                    {
                        tempList.Add(inputArray[i]);
                    }
                }
                if (tempList.Any())
                {
                    Console.WriteLine($"[{string.Join(", ", tempList.Take(count))}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void Min(int[] inputArray, string secondCommand)
        {
            var tempList = inputArray.ToList();
            var result = 0;
            
                if (secondCommand == "even")
                {
                    if (tempList.Where(x => x % 2 == 0).Any())
                    {
                    result = tempList.Where(x => x % 2 == 0).Min();
                    Console.WriteLine(tempList.LastIndexOf(result));
                }
                    else
                    {
                    Console.WriteLine("No matches");
                    }
                    
                }
                else if (secondCommand == "odd")
                {
                if (tempList.Where(x => x % 2 != 0).Any())
                {
                    result = tempList.Where(x => x % 2 != 0).Min();
                    Console.WriteLine(tempList.LastIndexOf(result));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            
         }

        private static void Max(int[] inputArray, string secondCommand)
        {
            var tempList = inputArray.ToList();
            var result = 0;
            
                if (secondCommand == "even")
                {
                    if (tempList.Where(x => x % 2 == 0).Any())
                    {
                        result = tempList.Where(x => x % 2 == 0).Max();
                        Console.WriteLine(tempList.LastIndexOf(result));
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    
                }
                else if (secondCommand == "odd")
                {
                    if (tempList.Where(x => x % 2 != 0).Any())
                    {
                        result = tempList.Where(x => x % 2 != 0).Max();
                        Console.WriteLine(tempList.LastIndexOf(result));
                    }
                }
        }

        private static int[] Exchange(int[] inputArray, int index)
        {
            var leftSide = inputArray.Take(index + 1).ToList();
            var rightSide = inputArray.Skip(index + 1).ToList();
            inputArray = rightSide.Concat(leftSide).ToArray();
            return inputArray ;
            
        }
        private static bool IsValid(int[] inputArray, int index)
        {
            bool isValid = true;
            if (index<0 || index>inputArray.Length)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
