using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            int endIndex= jump;
            if (text[i] == 'p')
            {
                hasMatch = true;
                if (endIndex > text.Length-i)
                {
                    endIndex = text.Length;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}