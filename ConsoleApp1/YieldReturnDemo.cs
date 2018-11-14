using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class YieldReturnDemo
    {
        public YieldReturnDemo()
        {
            //1.
            ArrayList list = new ArrayList();

            list.Add("1");
            list.Add(2);
            list.Add("3");
            list.Add('4');

            Console.WriteLine(" == regualer ArrayList object ==");
            foreach (object s in list)
            {
                Console.WriteLine(s);
            }
            MyArrayList mylist = new MyArrayList();

            mylist.Add("1");
            mylist.Add(2);
            mylist.Add("3");
            mylist.Add('4');

            Console.WriteLine(" == IEnumerable  ArrayList object ==");
            foreach (object s in mylist)
            {
                Console.WriteLine(s);
            }

            //2.
            List<string> listOfString = new List<string>();

            listOfString.Add("one");
            listOfString.Add("two");
            listOfString.Add("three");
            listOfString.Add("four");

            Console.WriteLine(" == regualer List string ==");
            foreach (string s in listOfString )
            {
                Console.WriteLine(s);
            }
            MyList<string> mylistOfString = new MyList<string>();

            mylistOfString.Add("one");
            mylistOfString.Add("two");
            mylistOfString.Add("three");
            mylistOfString.Add("four");

            Console.WriteLine(" == IEnumerable<T> List string ==");
            foreach (string s in mylistOfString)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine(" == reguler return will only return first one ==");
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(" == IEnumerable yield return will return all one by one ==");
            foreach (int i in YieldReturn ())
            {
                Console.WriteLine(i);
            }
        }

        static int SimpleReturn()
        { 
            // will return first one only
            return 1;
            return 2;
            return 3;
        }

        static IEnumerable<int> YieldReturn()
        {
            //will return all 3 
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }

    class MyArrayList: IEnumerable
    {
        object[] m_items = null;
        int freeIndex = 0;

        public MyArrayList ()
        {
            m_items = new object[100];
        }

        public void Add(object item)
        {
            m_items[freeIndex] = item;
            freeIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in m_items )
            {
                if (o == null) { break; }
                yield return o;
            }
        }
    }

    class MyList<T> : IEnumerable<T>
    {
        T[] m_items = null;
        int freeIndex = 0;

        public MyList()
        {
            m_items = new T[100];
        }

        public void Add(T item)
        {
            m_items[freeIndex] = item;
            freeIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T o in m_items)
            {
                if (o == null) { break; }
                yield return o;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
