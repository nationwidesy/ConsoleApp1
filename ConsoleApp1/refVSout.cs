using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class refVSout
    {
        public static void GetNextNumber (ref int id)
        {
            id += 1;
        }

        public static void GetNextNumber( int id)
        {
            id += 1;
        }

        public static void GetTheNumber(out int id)
        {
            id = 0;
        }
        public static void GetTheNumber( int id)
        {
            id = 100;
        }

        public static void refVSoutTest()
        {
            int i=1;
            Console.WriteLine($"the value before calling ref method : {i}");
            GetNextNumber(ref i);
            Console.WriteLine($"the value after calling ref next number method : {i}");
            GetTheNumber(out i);
            Console.WriteLine($"the value after calling out the value 0 method : {i}");
            GetTheNumber(i); //value i won't pass out to calling method
            Console.WriteLine($"the value after calling the value 100 method : {i}");
            GetNextNumber( i); //value i won't pass out to calling method
            Console.WriteLine($"the value after calling next number method : {i}");
        }
    }
}
