using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class IEnumerableDemo
    {
        public IEnumerableDemo ()  //default constractor
        {
            //1. example
            IEnumerable<int> Values = from value in Enumerable.Range(1, 10) select value; //LINO query

            foreach (int a in Values)
            {
                Console.WriteLine(a);
            }

            double average = Values.Average();
            Console.WriteLine("average = " + average);

            //2. example
            List<string> List = new List<string>();
            List.Add("Sourav");
            List.Add("Ram");
            List.Add("shyam");
            List.Add("Sachin");

            IEnumerable names = from n in List
                                where (n.StartsWith("S"))
                                select n; //LINO query
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //3. example
            Test t1 = new Test();
            t1.Name = "Sophy";
            t1.Surname = "Yang";

            Test t2 = new Test();
            t2.Name = "Tammy";
            t2.Surname = "Yang";

            Test myList = new Test();
            myList.Add(t1);
            myList.Add(t2);

            foreach (Test obj in myList )
            {
                Console.WriteLine("Name:- " + obj.Name + " Surname:-" + obj.Surname); 
            }

            Display(new List<bool> { true, false, true, true, false });
        }

        //for 3. example
        class Test : IEnumerable //implement IEnumerable interface 
        {
            Test[] Items = null;
            int freeIndex = 0;
            public String Name { get; set; }
            public string Surname { get; set; }

            public Test() //default constractor
            {
                Items = new Test[100];
            }
            public void Add(Test item)
            {
                Items[freeIndex] = item;
                freeIndex++;
            }


            public IEnumerator GetEnumerator() //IEnumerable only Member
            {
                foreach (object o in Items)
                {
                    if (o == null)
                    {
                        break; //since this array has space for 10 objects, if you only add 2 items to it, it still can handle
                    }
                    yield return o; //The function returns an object that implements the IEnumerable interface.
                    //yield improve performance, since yield allows eah iteration in a foreadh-loop be generated only when needed
                    //yield return object one by one
                }
            }
        }

        static void Display (IEnumerable  <bool> argument)
        {
            foreach (bool value in argument )
            {
                Console.WriteLine(value);
            }
        }
    }
}
