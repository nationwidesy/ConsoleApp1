using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //1. delegate
    public delegate int Comparer(object obj1, object obj2);

    class Name
    {
        public string FirstName = null;
        public string LastName = null;

        public Name(string first, string last)// constractor
        {
            FirstName = first;
            LastName = last;
        }
        //3. method
        public static int CompareFirsNames(object obj1, object obj2)
        {
            string n1 = ((Name)obj1).FirstName; //convert obj1 to Name data type
            string n2 = ((Name)obj2).FirstName;

            if (string.Compare(n1, n2) > 0)
            {
                return 1;
            }
            else if (string.Compare(n1, n2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class SimpleDelegate
    {
        Name[] names = new Name[6];
        public SimpleDelegate () //constructor
        {
            names[0] = new Name("abhishek", "jaiswal");
            names[1] = new Name("ashish", "verma");
            names[2] = new Name("gopi", "chand");
            names[3] = new Name("hari", "prakash");
            names[4] = new Name("prashant", "kumar");
            names[5] = new Name("pratiyush", "anand");
        }

        public void Sort(Comparer compare ) //Comparer is delegate, take 2 object parameter
        {
            object temp;
            for (int i = 0; i <names.Length; i++)
            {
                for (int j = 0 ; j< names.Length; j++)
                {
                    if (compare(names[i], names[j]) >0)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = (Name)temp;
                    }
                }
            }
        }
        public   void PrintName()
        {
            Console.WriteLine("Named: \n");
            foreach (Name name in names)
            { Console.WriteLine( name.ToString() ); }
        }

        public  void NameDemo()
        {
            SimpleDelegate sd = new SimpleDelegate();
            //2. assign delegate to object with new, parameter is a method
            Comparer cmp = new Comparer(Name.CompareFirsNames );
            Console.WriteLine("\nBefore Sorting:");
            sd.PrintName();
            //4.run method
            sd.Sort(cmp);
            Console.WriteLine("\nAfter Sorting:");
            sd.PrintName();
        }
    }
}
