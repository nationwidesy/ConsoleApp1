using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EnumDemo
    {
        public enum DayofWeek {
            Sunday= 3,
            Monday,
            Tuesday = 3,
            Wednesday,
            Thursday,
            Friday = 9,
            Saturday
        }
        public static void EnumDemoTest()
        {
            Console.WriteLine("=== Enum ====");

            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Monday, DayofWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Tuesday, DayofWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Wednesday, DayofWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Thursday, DayofWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Friday, DayofWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Saturday, DayofWeek.Saturday);

            string[] values = Enum.GetNames(typeof(DayofWeek));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            int[] nums = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                    //break;
                }
                Console.WriteLine("The number is "+ i); 
            }
        }
    }

    

}
