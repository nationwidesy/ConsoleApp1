using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayDemo1
    {
        public ArrayDemo1()
        {
            int[] array1 = new int[5];

            float[] array2;
            array2 = new float[6];

            int[] array3 = new int[5] { 15, 3, 7, 8, 9 };

            int[] array4 = { 1, 2, 3, 4, 5 };
            string[] array5 = { "A", "J", "A", "Y" };
            bool[] array6 = { true, false };

            int x = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (x > array3[i])
                {
                    continue;
                }
                else
                {
                    x = array3[i];
                }
            }
            Console.WriteLine("the largest number is " + x);
        }

        public void ListDemo()
        {
            List<int> list = new List<int>();
            for (int i =1; i<= 5; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Average number is " + list.Average() );
            Console.WriteLine("Total elements in the List is " + list.Count);
            


        }
    }
}
