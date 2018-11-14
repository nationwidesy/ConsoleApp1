using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    //delegate class can change method calls, and also plug new code into existing classes
    delegate void Dele(string UserName);
    public delegate int DelegateMethod(int x, int y);
    public delegate void delmethod();
    public delegate void multidelmethod(int x, int y);
    public delegate void AnonymousDelMethod();
    public delegate void eventdelmethod(int a);


    class DelegateDemo
    {
        public Dele delObject;
        public Dele delObject2;
        public event eventdelmethod MyEvent;
        public event multidelmethod MyMultiEven;
         

        public DelegateDemo()  
        {
             delObject = new Dele(this.SayHello);
             delObject2 = new Dele(this.SecondHello);
            delmethod delegateMethodA = new delmethod(display);
            delmethod delegateMethodB = new delmethod(print );
            delObject("Tammy");
            delObject2("Tammy");
            delegateMethodA();
            delegateMethodB();
            delegateMethodB = new delmethod(show );
            delegateMethodB();

            PrintString.PrintStringDemo();
            AnonymousDelegate.anonymousDelegateTest();

            //A();
 

        }

        static void A ()
        {
            Counter c = new Counter(new Random().Next(10)); //Counter is a class
            //assign a random number to Counter.threshold field/property
            c.ThresholdReached += c_ThresholdReached; //add funtion/method

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.Write("The threshold was reached.");
            Environment.Exit(0);
        }

        public void SayHello(string UserName)
        {
            Console.WriteLine("Hello... " + UserName + ", from class DelegateDemo");
        }
        public void SecondHello(string UserName)
        {
            Console.WriteLine("It is me again from " + UserName + ", from class DelegateDemo");
        }
        public static void display()
        {
            Console.WriteLine("Hello this is display method");
        }
        public void print()
        {
            Console.WriteLine("This is Print");
        }
        public static void show()
        {
            Console.WriteLine("Show me!");
        }
        public void plus_Method(int x, int y)
        {
            Console.Write("You are in plus_Method");
            Console.WriteLine(x + y);
        }
        public void substract_Method(int x, int y)
        {
            Console.Write("You are in sbustract_Method");
            Console.WriteLine(x - y);
        }
        public void RaiseEvent()
        {
            MyEvent(20);
            Console.WriteLine("Event raise");
        }
        public void Display(int x)
        {
            Console.WriteLine("Display Method {0}", x);
        }
        public void Add(int x, int y)
        {
            Console.WriteLine("Add Method {0}", x + y);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Method {0}", x - y);
        }
        public void RaiseMultiEvent (int x, int y)
        {
            this.MyMultiEven(x, y);
            Console.WriteLine("Multi Event raise");
        }
    }

    public class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void printString(string s); //delegate

        public static void WriteToScreen(string str) //method A
        {
            Console.WriteLine("The String is: {0}", str);
        }

        public static void WriteToFile(string s)// method B
        {
            fs = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SophyWriteLines.txt",
                FileMode.Append , FileAccess.Write );
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void sendString(printString ps)//parameter is delegate type, is method
        {
            ps("Hello World " + DateTime.Now); //delegate, method
        }

        public static void PrintStringDemo() //method
        {
            printString ps1 = new printString(WriteToScreen); //delegate
            ps1 += new printString(WriteToFile); //Add function +=
            ps1 -= new printString(WriteToFile); //remove function -=
            sendString(ps1); //method param is delegate method
        }
    }

    public class AnonymousDelegate
    {
        delegate void Test();
        // if a delegate itself contains its method definition it is known as anonymous method.
             public static void anonymousDelegateTest()
            {
                Test Display = delegate() //lambda expression
                {
                    Console.WriteLine("Anonymous Delegate Method: delegate itself contain its method definition (lambda expression)");
                };
                Display();
                
            }
        }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter (int passedThreshold) //constructor
        {
            threshold = passedThreshold;
        }

        public void Add(int x) 
        {
            total += x;
            if (total >= threshold )
            {
               
                onThresholdReached(EventArgs.Empty); 
            }
        }

        protected virtual void onThresholdReached(EventArgs e) //method, event handler is a method
        {
            EventHandler handler = ThresholdReached; //event ThresholdReached
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler ThresholdReached; //event, EventHandler and EventHandler<TEventArgs> are delegate
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

}
 