using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Demo
    {
        int mdata;
        public Demo() //instance constructor, no arguments, is called a default constructor
        {
            mdata = 45;
        }
        public Demo(int mdata)  //instance constructor, generate by keyword new
        {
            this.mdata = mdata;
        }
        public void Show()
        {
            Console.WriteLine(mdata);
        }
        public void showDateTime()
        {
            DateTime dat = DateTime.Now;
            Console.WriteLine("The time: {0:d} at {0:t}", dat);

            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine("The time zone: {0}\n", tz.IsDaylightSavingTime(dat) ? tz.DaylightName : tz.StandardName);
            Console.WriteLine("Press <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        public static void ShowPressedKey()
        {
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();  // ReadKey read from the keyboard
                Console.Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("Shift+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("Ctrl+");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
        }
        public static void doMath() 
        {
            double dub = -3.14;
            Console.Write("Abs( {0} ) = ", dub);
            Console.WriteLine(Math.Abs(dub));
            Console.Write("Floor( {0} ) = ", dub);
            Console.WriteLine(Math.Floor(dub));
            Console.Write("Round(Abs( {0} )) = ", dub);
            Console.WriteLine(Math.Round(Math.Abs(dub)));
        }
        public static void DoStringStringBuilder()
        {
            int dt1 = DateTime.Now.Millisecond;
            Console.WriteLine();
            string x = string.Empty;
            for (int i=0; i< 100000; i++)
            {
                x += "!";
            }
            int dt2 = DateTime.Now.Millisecond;
            Console.WriteLine("Time take in string concatation: {0} MS", dt2 - dt1);

            int dt3 = DateTime.Now.Millisecond;
            StringBuilder builder = new StringBuilder();
            for (int i=0; i < 100000; i++)
            {
                builder.Append("!");
            }
            x = builder.ToString();
            int dt4 = DateTime.Now.Millisecond;
            Console.WriteLine("Time take in StringBuilder concatation: {0} MS", dt4 - dt3);       
        }
        public static void NullableDemo()
        {
            string str = string.Empty;
            int counter = 0;
            try
            {
                counter += 1;
                int? w = null;
                counter += 1;
                var x = 4;
                var x1 = x;
                //counter += 1;
                //var? y = null;
                

                counter += 1;
                int? result;
                result = w ?? x;
                Console.WriteLine($"result = ({result.ToString() })");

                result = x * x1;
                Console.WriteLine($"result = ({result.ToString() })");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred at point {1} ({0})" , e.Message, counter );
            }
            finally {
                Console.WriteLine("=== Done testing Nullable");
            }
        }
    }

    public class Class1
    {
        public string Display()
        {
            return ("I am in Display");
        }
        public string Print()
        {
            return ("I am in Print");
        }
    }

    //Partial class name are same, so only need do one new keywork
    partial class PartialClasses
    {
        public void Function1() { Console.WriteLine("Function 1"); }
    }
    partial class PartialClasses
    {
        public void Function2() { Console.WriteLine("Function 2"); }
    }

    class Class2
    {
    //
    }
    //is Operator and as Operator
    public class IsTest
    {
        public static void Test(object o)
        {
            Class1 a;
            Class2 b;
            if(o is Class1)
            {
                Console.WriteLine("o is Class1");
                a = (Class1)o;
            }
            else if (o is Class2)
            {
                Console.WriteLine("o is Class2");
                b = (Class2)o;
            }
            else
            {
                Console.WriteLine("o is neither Class1 nore Class2");
            }
        }
        public static void asTest()
        {
            object[] myObjs = new object[6];
            myObjs[0] = new Class1();
            myObjs[1] = new Class2();
            myObjs[2] = "string";
            myObjs[3] = 32;
            myObjs[4] = null;
            for (int i=0; i<myObjs.Length;i++)
            {
                string s = myObjs[i] as string;
                Console.Write("{0}", i);
                if (s != null)
                {
                    Console.WriteLine(" '" + s + "'");
                }else
                {
                    Console.WriteLine(" not a string");
                }
            }
             
        }
    }
}
