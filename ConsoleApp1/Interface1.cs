using System;

/*
 * all are public, only public are allowed
 * 
 */
namespace ConsoleApp1
{
   interface Interface1
    {
        //int x = 4; interface cannot contain filed
        void getMethod(); 
        string getName();
        //public Interface1() { } interface cannot have constructor
        //public void test(); access specifier is not allowed all are public
         
    }

    public interface InfA { void Display(); } //interface method is abastracr no method body
    interface InfB { void Display(); }

    class Cinterface : InfA, InfB //can inheritance multi interface
    {
        public void Display()
        {
            Console.WriteLine("i am in interfaceA Display method");           
        }
        void InfB.Display()
        {
            Console.WriteLine("i am in interfaceB Display method");
        }
        public static void InterfaceTest()
        {
            Cinterface ci = new Cinterface();
            InfA infA = (InfA)ci; //interface can not use new keyword to create object
            InfB infB = (InfB)ci;
            infA.Display();
            infB.Display();
        }
    }

    interface IMobilePhone
    {
        void ReceiveCall();
        void EndCall();
        void DialNumber();
    }

    class A : IMobilePhone
    {
        public void DialNumber()
        {
            Console.WriteLine("class A :Number Dialed");
        }

        public void EndCall()
        {
            Console.WriteLine("class A :Call Ended");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("class A :Call Received");
        }
        public void aTest()
        {
            Console.WriteLine("=====class A=====");
        }
    }

    class B: IMobilePhone
    {
        public void DialNumber()
        {
            Console.WriteLine("class B :Number Dialed");
        }

        public void EndCall()
        {
            Console.WriteLine("class B :Call Ended");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("class B :Call Received");
        }

        public void aTest()
        {
            Console.WriteLine("====class B=====");
        }

        public static void InterfaceTest()
        {
            A a = new A(); //class A
            B b = new B(); //class B
            a.aTest();
            a.DialNumber();
            a.ReceiveCall();
            a.EndCall();
            b.aTest();
            b.DialNumber();
            b.ReceiveCall();
            b.EndCall();

            IMobilePhone iA = (IMobilePhone)a; //interface
            iA.DialNumber();
            iA.ReceiveCall();
            iA.EndCall();
            IMobilePhone iB = (IMobilePhone)b;
            iB.DialNumber();
            iB.ReceiveCall();
            iB.EndCall();

 
            MyFather f = new MyFather();
            MyMother m = new MyMother();

            f.Name = "James";
            m.Name = "Jennifer";

            Console.WriteLine("My {0} is {1}", f.ParentTitle(), f.Name);
            Console.WriteLine("My {0} is {1}", m.ParentTitle(), m.Name);

            Childer c = new Childer();
            c.Name = "Sophy";
            c.title  = "Father";
            c.parentName = "Jame";
            Console.WriteLine("{2}'s {0} is {1}", c.ParentTitle(), c.ParentName(), c.Name );


            iFive obj = new OddEven(); //iFive (small) OddEven (bigger)
            obj.One();
            obj.Three() ;
            obj.Five();

            iEven obj1 = new OddEven();
            obj1.Two();
            obj1.Four();

            ILog log = new ConsoleLog();
            ILog log1 = new FileLog();
            log.Log("sending log to console");
            log1.Log("write log to log.txt");

            infDemo.infDemoTest(); //public static method
        } 
    }
    
    interface MyParent
    {
        string ParentName();
        string ParentTitle();
    }

    class MyFather : MyParent
    {
        public string Name;
        public string ParentName()
        {
            return Name;
        }

        public string ParentTitle()
        {
            return "Father";
        }
    }
    class MyMother : MyParent
    {
        public string Name;
        public string ParentName()
        {
            return Name;
        }

        public string ParentTitle()
        {
            return "Mother";
        }
    }
    class Childer :   MyParent
    {
        public string parentName;
        public string title;
        public string Name { get; set; }
        public string ParentName() { return parentName;  }
        public string ParentTitle() { return title;  }
    }

    interface iOne
    {
        void One();
    }
    interface iTwo
    {
        void Two();
    }
    interface iThree : iOne
    {
        void Three();
    }
    interface iFour
    {
        void Four();
    }
    interface iFive : iThree
    {
        void Five();
    }

    interface iEven : iTwo, iFour { }

    class OddEven : iEven, iFive
    {
        public void Five()
        {
            Console.WriteLine("This is five");
        }

        public void Four()
        {
            Console.WriteLine("This is four");
        }

        public void One()
        {
            Console.WriteLine("This is one");
        }

        public void Three()
        {
            Console.WriteLine("This is three");
        }

        public void Two()
        {
            Console.WriteLine("This is two");
        }
    }

    interface ILog { void Log(string msgToLog); }

    class ConsoleLog : ILog
    {
        public void Log(string msgToPrint) //explicit implementation
        {
            Console.WriteLine(msgToPrint);
        }
    }

    class FileLog : ILog
    {
        public void Log(string msgToPrint)
        {
            System.IO.File.AppendAllText(@"C:\Users\Sophy_2\Documents\Log.txt",msgToPrint+Environment.NewLine );
        }
    }

    interface abc { void xyz(); }
    interface def { void pqr(); }
    interface ghi { void pqr(); }
    interface multi_1 { void pqr1(); }
    interface multi_2 : multi_1 { void pqr2(); }

    class Sample : abc
    {
        public  void xyz()
        {
             Console.WriteLine ("In Sample :: xyz");
        }
    }

 

    class infDemo : abc, def, ghi, multi_2 //ghi mothed name same as def so don't nee implemenet 
    {
        public static void infDemoTest ()
        {
            Console.WriteLine("Hello Interfaces");
            infDemo inf = new infDemo();
            inf.pqr();
            Console.WriteLine("new class infDemo");
            abc infa = (abc)inf; //interface
            infa.xyz();
            Console.WriteLine("interface abc");
            Sample s = new Sample();
            s.xyz();
            Console.WriteLine("new class Sample");
            abc infb = (abc)s;
            infb.xyz();
            Console.WriteLine("interface abc");

            abc infc = new infDemo(); //new keywork interface
            infc.xyz();
             

            abc[] infArray = { new infDemo(), new Sample() };
            for (int i = 0; i < infArray.Length; i++)
            {
                infArray[i].xyz();
            }
        }

        public void pqr() //must have public
        {
            Console.WriteLine("In infDemo :: pqr");
        }

        public void pqr1()
        {
            Console.WriteLine("In infDemo :: pqr1");
        }

        public void pqr2()
        {
            Console.WriteLine("In infDemo :: pqr2");
        }

        void abc.xyz() //interface don't need public
        {
             Console.WriteLine ("In infDemo :: xyz");
        }
    }
}
