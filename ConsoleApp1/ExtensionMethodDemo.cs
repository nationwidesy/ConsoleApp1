using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1; //sophy's class library

namespace ConsoleApp1
{
    class ExtensionMethodDemo
    {
    }

    public class Class3
    {
        public void Display()
        {
            Console.WriteLine("I am in Display");
        }
        public void Print()
        {
            Console.WriteLine("I am in Print");
        }
    }

    public static class XX11 
    {
        public static void NewMethod11 (this Class3 obj) //extension method, static, this
        {
            Console.WriteLine("Hello I am extended method");
        }
        public static void NewMethod15(this Class3 obj)
        {
            Console.WriteLine("I am extended Class3 NewMethod15");
        }

    }

    public static class XX22
    {
        public static void NewMethod13(this Class1 obj) //extension method
        {
            Console.WriteLine("I am extended ClassLibrary1.Class1 NewMethod13");
        }

        public static void NewMethod14(this Class1 obj)
        {
            Console.WriteLine("I am extended ClassLibrary1.Class1 NewMethod14");
        }

    }

    public static class ExtensionMethodDemoTest
    {
        public static void ExtemsionMethod ()
        {
            Class3 c = new Class3();
            c.Display();
            c.Print();
            c.NewMethod11();
            c.NewMethod15();
            
           
           

            Class1 c1 = new Class1();
            c1.Display();
            c1.Print();
            c1.NewMethod();
            c1.NewMethod13();
            c1.NewMethod14();
            

        }
    }

}
