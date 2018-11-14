using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MDelegate();
    class MultiDelegate
    {
        static public void Display()
        {
            Console.WriteLine("MultiDelegate Display method");
        }
        static public void Print()
        {
            Console.WriteLine("MultiDelegate Print method");
        }
    }
    class MultiDeleTest
    {
        public MultiDeleTest()
        {
            MDelegate m1 = new MDelegate(MultiDelegate.Display);
            MDelegate m2 = new MDelegate(MultiDelegate.Print);
            MDelegate m3 = m1 + m2; //add Display and Print to m3
            MDelegate m4 = m2 + m1; //add Print and Display to m4
            MDelegate m5 = m3 - m2; // add Display +  Print - Print =  Display to m5
            m3(); //Display, Print
            m4(); //Print, Display
            m5(); //Display
        }
    }
}

