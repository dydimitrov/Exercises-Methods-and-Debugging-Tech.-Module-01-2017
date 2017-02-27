using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, string>();

            while (input !="stop")
            {
                var name = input;
                var mail = Console.ReadLine();
                if (CheckMail(mail))
                {
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, mail);
                    }
                    else
                    {
                        result[name] = mail;
                    }
                }
                input =Console.ReadLine();
                
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
        public static bool CheckMail(string input)
        {
            bool IsCorrect = true;
            var symbols = input.ToLower().Split('.').ToArray();
            Array.Reverse(symbols);
            if (symbols[0]=="us" || symbols[0] == "uk")
            {
                IsCorrect = false;
            }
            return IsCorrect;
        }
    }
}
