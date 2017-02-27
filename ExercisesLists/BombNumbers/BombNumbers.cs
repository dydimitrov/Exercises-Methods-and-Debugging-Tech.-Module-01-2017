using System; 
using System.Linq; 
using System.Collections; 


public class BombNumbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var bombInfo = Console.ReadLine().Split().Select(int.Parse).ToList();
        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        while (inputNumbers.Contains(bombNumber))
        {
            for (int index = 0; index < inputNumbers.Count; index++)
            {
                if (inputNumbers[index] == bombNumber)
                {
                    int bombIndex = index;

                    int front = bombIndex - bombPower;

                    if (front < 0)
                        front = 0;

                    int back = bombIndex + bombPower;

                    if (back >= inputNumbers.Count)
                        back = inputNumbers.Count - 1;

                    for (int i = front; i <= back; i++)
                        inputNumbers.RemoveAt(front);
                }
            }
        }

        

        Console.WriteLine(inputNumbers.Sum());
        
    }
}