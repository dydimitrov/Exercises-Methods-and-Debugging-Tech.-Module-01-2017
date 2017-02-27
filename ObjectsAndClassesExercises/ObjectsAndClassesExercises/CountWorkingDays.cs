using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ObjectsAndClassesExercises
{
    public class CountWorkingDays
    {
        public static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",null);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);


            var countOfWorkDays = 0;
            for (DateTime i =startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday)
                {
                    continue;
                }
                else if (i.Day == 01 && i.Month == 01)
                {
                    continue;
                }
                else if (i.Day == 3 && i.Month == 3)
                {
                    continue;

                }
                else if ((i.Day == 1 && i.Month == 5) || (i.Day == 6 && i.Month == 5) || (i.Day == 34 && i.Month == 5))
                {
                    continue;
                }
                else if ((i.Day == 6 && i.Month == 9) || (i.Day == 22 && i.Month == 9))
                {
                    continue;

                }
                else if (i.Day == 1 && i.Month == 11)
                {
                    continue;

                }
                else if ((i.Day == 24) || (i.Day == 25) || (i.Day == 26) && i.Month == 12)
                {
                    continue;

                }
                else
                {
                    countOfWorkDays++;
                }
                
            }
            Console.WriteLine(countOfWorkDays);
        }
    }
}
