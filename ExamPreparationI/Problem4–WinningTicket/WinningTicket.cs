using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem4_WinningTicket
{
    public class WinningTicket
    {
        public static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(t=>t.Trim())
                                        .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var left = new string (ticket.Take(10).ToArray());
                var right = new string(ticket.Skip(10).ToArray());

                var isWinning = false;
                var winSymbols = new string[] { "@", "#", "\\$", "\\^"};
                foreach (var symbol in winSymbols)
                {
                    var regEx = new Regex($"{symbol}{{6,}}");
                    var leftMatch = regEx.Match(left);
                    if (leftMatch.Success)
                    {
                        var rightMatch = regEx.Match(right);
                        if (rightMatch.Success)
                        {
                            isWinning = true;
                            var symbolsLengthLeft = leftMatch.Value.Length;
                            var symbolsLengthRight = rightMatch.Value.Length;
                            var jackpot = symbolsLengthLeft == 10 && symbolsLengthRight==10 ? "Jackpot!" : string.Empty;
                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(symbolsLengthLeft,symbolsLengthRight)}{symbol.Trim('\\')} {jackpot}");
                            break;
                        }

                    }
                }
                if (!isWinning)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }


        }
    }
}
