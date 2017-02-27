using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
        }
        public static string StringCreater(string text, int repeatCount)
        {
            string DayOfWeek = string.Empty;
            for (int currentCount = 0; currentCount < repeatCount; currentCount++)
            {
                DayOfWeek += text;
            }
            return DayOfWeek;
        }
    }
}
