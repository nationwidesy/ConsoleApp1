using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1; //Sophy's library

namespace ConsoleApp1
{
    delegate void Del(string UserName); //delegate is a class
    class TestDelegate
    {
        public Del delObject;
        public TestDelegate()
        {
            delObject = new Del(this.SayHello);
        }
        public void SayHello(string UserName)
        {
            Console.WriteLine("Hello.. " + UserName + ", from TestDelgate");
        }
    }
    public static class XX
    {
        public static void NewMethod(this Class1 ob) //extension method, this, static
        {
            Console.WriteLine("Hello I am extended method");
        }
        public static int WordCount(this string str)
        {
            string[] userString = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length;
            return wordCount;
        }
        public static int TotalCharWithoutSpace(this string str)
        {
            int totalCharWithoutSpace = 0;
            string[] userString = str.Split(' ');
            foreach (string stringValue in userString)
            {
                totalCharWithoutSpace += stringValue.Length;
            }
            return totalCharWithoutSpace;
        }

    }
    public static class XX_dll
    {
        public static void NewMethod(this ClassLibrary1.Class1 ob) //extension method
        {
            Console.WriteLine("Hello I am extended method from ClassLibrary1");
        }
    }

 
    public static class ExtMetClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str); //convert a string to a numeric type
        }
    }
    class myClass
    {
        static myClass()
        {
            Console.WriteLine("This is me a class");
        }
    }

    class myEnum
    {
        public enum DayofWeek { Sunday=2, Monday, Tuesday = 1, Wednesday, Thursday=2, Friday, Saturday}
        static myEnum()
        {
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Sunday, DayOfWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Monday, DayOfWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Tuesday, DayOfWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Wednesday, DayOfWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Thursday, DayOfWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Friday, DayOfWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Saturday, DayOfWeek.Saturday);

            string[] values = Enum.GetNames(typeof(DayofWeek));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            int[] n = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach (int x in n) {
                Console.WriteLine(x);
           
            }
            //Console.ReadLine();
        }
    }

    class Test
    {
        readonly int read = 10;
        const int cons = 15;
        readonly static int readOnly = 20;
        public Test() //constructor
        {
            read = 100;
        }
        public Test(int input)
        {
            read = input;
        }
        static Test()
        {
            readOnly = 2000;
        }
        public void Check()
        {
            Console.WriteLine("Read only: {0} ( {1} )", read, " immutable values, can assign a new value by keyword new");
            Console.WriteLine("const: {0} ( {1} )", cons, " immutable values, constant value cannot be changed");
            Console.WriteLine("Read only static: {0} ( {1} )", readOnly, " static so value cannot be changed");
            myTest3(read);
        }

        static void myTest1()
        {
            Console.WriteLine("Read only static: {0} ( {1} )", readOnly, " static can only change in the static constructor");
        }

        static int myTest2()
        {
            return 999;
        }

        static void myTest3(int input)
        {
            Console.WriteLine(" you just keyin {0} ", input);
        }
        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            id += 1;
            string returnText = "Out Next-" + id.ToString();
              return returnText;
         }
        public static string GetNextNameByRef(ref int id)
        {
            id += 1;
            string returnText = "Ref Next-" + id.ToString();
            return returnText;
        }
        public static string GetNextNameByRef(int id)
        {
            id += 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        public static void Show(int number)
        {
            //number = 60;
            number += 23; //won't add 23, the value will not pass out of called method
            number += 1;
        }
        public static void Show(ref int number)
        {
            number += 23; //ref - initialized value in before called method
        }
        public static void ShowOut(out int number)
        {
            number = 23; //out - need initialized value in called method
            number += 23;
        }
 
    } //class Test

    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Hello World!! This is Sophy");
            Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
            myClass c = new myClass();
            //Console.ReadLine();
            myEnum e = new myEnum();
            Test obj = new Test();
            obj.Check();
            Test obj2 = new Test(200);
            obj2.Check();
            Test obj3 = new Test(300);
            obj3.Check();
            int i = 0;
            String outStr1 = Test.GetNextNameByRef(ref i);
            Console.WriteLine(outStr1);
            Console.WriteLine("ref Current value of integer i: " + i.ToString());
            outStr1 = Test.GetNextNameByRef(ref i);
            Console.WriteLine(outStr1);
            Console.WriteLine("ref Current value of integer i: " + i.ToString());
            outStr1 = Test.GetNextNameByRef(i);
            Console.WriteLine(outStr1);
            Console.WriteLine("Current value of integer i: " + i.ToString());
            outStr1 = Test.GetNextNameByRef(i);
            Console.WriteLine(outStr1);
            Console.WriteLine("Current value of integer i: " + i.ToString());
            Console.WriteLine("Previous value of integer i: " + i.ToString());
            outStr1 = Test.GetNextNameByOut(out i);
            Console.WriteLine(outStr1);
            Console.WriteLine("out Current value of integer i: " + i.ToString());
            outStr1 = Test.GetNextNameByOut(out i);
            Console.WriteLine(outStr1);
            Console.WriteLine("out Current value of integer i: " + i.ToString());
            int x = 10;
            Test.Show(x);
            Console.WriteLine("Not Ref paramter get value from outside called method: " + x); //10
            Test.Show(ref x);
            Console.WriteLine("Ref paramter get value from called method: " + x);//10+23=33
            Test.Show(ref x);
            Console.WriteLine("Ref paramter get value from called method: " + x);//33+23=56
            Test.Show(x);
            Console.WriteLine("Not Ref paramter get value from outside called method: " + x);//56
            Test.Show(x);
            Console.WriteLine("Not Ref paramter get value from outside called method: " + x);//56
            Test.ShowOut(out x);
            Console.WriteLine("Out paramter get value from called method: " + x);//23+23=46 value in called method

            Demo d = new Demo();
            d.Show();
            Demo d1 = new Demo(44);
            d1.Show();

            Person p = new Person();
            p.Name = "Sophy Yang";
            p.State = "IA";
            Console.WriteLine("Your Name is {0}", p.Name);
            Console.WriteLine("Your State is {0}", p.State);
            //p.Company = "Multi-State Lottery Association"; readOnly cannot assign value
            Console.WriteLine("You are working at {0}", p.Company);
            p.Notes = "This is the testing C#";
            Console.WriteLine("Notes: {0}", p.showNotes);  //Notes is writeOnly can not get it

            Person objPerson = new Person()
            {
                Name = "Suki Bunny",
                Age = 24,
                City = "Des Moines",
                State = "IA"
            };
            Console.WriteLine("New Person Name: {0}", objPerson.Name);

            //Voter objVoter = new Voter();
            //Console.Write("Please enter your age: ");
            //objVoter.Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: {0} years", objVoter.Age);

            //d.showDateTime();//non-static class need use new to created 
            //Demo.ShowPressedKey(); //static class, been call by name
            //Demo.doMath(); //static class call by name no need new

            //Student objStudent = new Student();
            //Console.WriteLine("Please enter your marks: ");
            //objStudent.Marks = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your marks are: {0} marks", objStudent.Marks);
            ////Console.ReadKey();
            try
            {
                Employee objEmployee = new Employee()
                {
                    EmployeeId = 1001,
                    Name = "Sophy"
                };
                Console.WriteLine("Employee Id is: {0} and Employee Name is {1}", objEmployee.EmployeeId, objEmployee.Name);
                objEmployee.SetID(-30);
                Console.WriteLine("Employee Id is: {0} and Employee Name is {1}", objEmployee.EmployeeId, objEmployee.Name);
                Console.WriteLine("{1} your bonus: {0}", objEmployee.Bonus, objEmployee.Name);
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Class1 ob = new Class1();
            Console.WriteLine(ob.Display());
            Console.WriteLine(ob.Print());
            ob.NewMethod();

            ClassLibrary1.Class1 ob_dll = new ClassLibrary1.Class1();
            Console.WriteLine(ob_dll.Display());
            Console.WriteLine(ob_dll.Print());
            ob_dll.NewMethod();


            string str = "12345";
            int num = str.IntegerExtension();
            Console.WriteLine("The output using extension method: {0}", num);

            str = "This is sophy testing, total words count is 14, total char count is 57";
            num = str.WordCount();
            Console.WriteLine("Total word count: {0}", num);
            num = str.TotalCharWithoutSpace();
            Console.WriteLine("Total char count: {0}", num);

            //Write text to a new file
            // the Dispose method is invoked which automatically flushes and closes the stream.
            string[] lines = { "First line", "Second line", "Third line"};
            string mydocpath = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "sophyWriteLines.txt")))
            {
                foreach (string line in lines) outputFile.WriteLine(line);
            }
            Console.WriteLine(mydocpath);
            //Append text
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(mydocpath, "sophyWriteLines.txt"), true))
            {
                outputfile.WriteLine("Four line");
            }
            // Write the text asynchronously to a new file
            //ClassLibrary1.Class1.WriteTextAsync("hi, this is sophy writing the text asynchronously");
            string val = "Hello";
            val += " am ";
            val += "Nitin Pandit";
            Console.WriteLine(val);

            StringBuilder val_sb = new StringBuilder("");
            val_sb.Append("Hello ");
            val_sb.Append(" am Nitin Pandit: ");
            Console.WriteLine(val_sb);

            //Demo.DoStringStringBuilder();

            string string1 = "Today is " + DateTime.Now.ToString();
            Console.WriteLine(string1);
            string string2 = "Hi " + "This is Sophy";
            string2 += " Yang";
            //Console.WriteLine(string2);

            StringBuilder Number = new StringBuilder(100);
            
            for (int z =0; z<10; z++)
            {
                Number.Append(z);
            }
            //Console.WriteLine(Number);

            Console.WriteLine("===== Delegate Demo ====== ");
            TestDelegate obj_delegate = new TestDelegate();
            obj_delegate.delObject("sophy");

            DelegateDemo objD = new DelegateDemo(); //DelegateDemo is class, new will call default constractor
            objD.delObject("SophyYang"); //delObject is delegate signed by new
            objD.delObject2("Sukibunny");//delObject2 is delegate signed by new

            Console.WriteLine("===== Delegate Demo ====== ");
            //pass method as parameter: delegate
            delmethod del1 = DelegateDemo.show; //show() is public static method, delmethod is delegate class
            delmethod del2 = new delmethod(DelegateDemo.display); //display is public static method
             delmethod del3 = objD.print; //print is not static method, so need new created object 
            del1();
            del2();
            del3();

            Console.WriteLine("===== multicast Delegate Demo ====== ");
            multidelmethod del4 = new multidelmethod(objD.plus_Method);//plus_method is not static method
            del4 += new multidelmethod(objD.substract_Method);//substract_method is not static method
            del4(20, 10);
            Console.WriteLine("=====  Anonymous Delegate Demo ====== ");
            AnonymousDelMethod Display = delegate () //lambda expression
            {
                Console.WriteLine("Anonymous Delegate method");
            };
            Display();
            Console.WriteLine("=====  Event Delegate Demo ====== ");
            objD.MyEvent += new eventdelmethod(objD.Display); //Display is not static method
            //MyEvent will execuite method Display in class DelegateDemo
            objD.RaiseEvent();
            Console.WriteLine("=====  Multi Event Delegate Demo ====== ");
            objD.MyMultiEven += new multidelmethod(objD.Add);
            objD.MyMultiEven += new multidelmethod(objD.Subtract);
            objD.RaiseMultiEvent(30,50); //output 80, -20
            Console.WriteLine("=====  Partial classes Demo ====== ");
            PartialClasses pc = new PartialClasses();
            pc.Function1();
            pc.Function2();

            ExceptionDemo eDemo = new ExceptionDemo();
            try
            {
                //all 2 lines below are working
                eDemo.ExceptionMethod();
                //eDemo.AnotherMethod();
            }
            catch (Exception  ex)
            {
                //all 3 lines below are working
                //throw ex;
                //throw new ApplicationException("Sophy's exception could not get data", ex);
                Console.WriteLine("throw Sophy's exception ("+ex.Message +")");
            }

            string[] strArr = new string[1];
            eDemo.SophyExceptionArgumentDemo(strArr);
            strArr[0] = "2";
            eDemo.SophyExceptionArgumentDemo(strArr);

            i = 123456;
            Console.WriteLine("{0:C}", i); // $123,456.00 Currency
            Console.WriteLine($"{i:C}");   //$
            Console.WriteLine("{0:D}", i); // 123456 Decimal
            Console.WriteLine("{0:E}", i); // 1.234560E+005 Exponent
            Console.WriteLine("{0:F}", i); // 123456.00 Fixed point
            Console.WriteLine("{0:G}", i); // 123456 General
            Console.WriteLine("{0:N}", i); // 123,456.00 Currency
            Console.WriteLine("{0:P}", i); // 12,345,600.00 %
            Console.WriteLine("{0:X}", i); // 1E240 Hex
            i = 123456;
            Console.WriteLine();
            Console.WriteLine("{0:#0}", i);             // 123456

            Console.WriteLine("{0:#0;(#0)}", i);        // 123456

            Console.WriteLine("{0:#0;(#0);}", i); // 123456

            Console.WriteLine("{0:#%}", i);     // 12345600%


            i = -123456;
            Console.WriteLine();
            Console.WriteLine("{0:#0}", i);             // -123456

            Console.WriteLine("{0:#0;(#0)}", i);        // (123456)

            Console.WriteLine("{0:#0;(#0);}", i); // (123456)

            Console.WriteLine("{0:#%}", i);             // -12345600%


            i = 0;
            Console.WriteLine();
            Console.WriteLine("{0:#0}", i);             // 0

            Console.WriteLine("{0:#0;(#0)}", i);        // 0

            Console.WriteLine("{0:#0;(#0);}", i); // 

            Console.WriteLine("{0:#%}", i);             // %

            MultiDeleTest md = new MultiDeleTest();

            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            DelegateDemo c3 = new DelegateDemo();
            IsTest.Test (c1);
            IsTest.Test (c2);
            IsTest.Test(c3);
            IsTest.Test("Passing String Value instead of class");
            IsTest.asTest();

            Demo.NullableDemo();


            CompareTwoClass compareTwoClass = new CompareTwoClass (); //CompareTwoClassTest is static so don't need keywork "new" to call it

            AClass aclass = new AClass(); //AClass is not static so need use keywork "new"
            BClass bclass = new BClass();

            aclass.AMethod();
            bclass.AMethod();
            bclass.B2Method();
            bclass.B3Method();
            bclass.B4Method();
            Console.WriteLine(bclass.GetHashCode()); //return 21083178

            DataTypeConversion dataTypeConversion = new DataTypeConversion();

            BoxingUnboxing boxingUnboxing = new BoxingUnboxing();

            StructDemo structDemo = new StructDemo();
            //StructDemo structDemo1 = new StructDemo(10,10);            
            StructDemo structDemo1; //don't need use new keywork to create a object
            structDemo1.x = 10;
            structDemo1.y = 20;
            Console.WriteLine($"Struct Demo 1: x = {structDemo.x} y = {structDemo.y }");
            Console.WriteLine($"Struct Demo 2: x = {structDemo1.x} y = {structDemo1.y }");

            StructurePerson strX = new StructurePerson(); //structure is value type
            StructurePerson strY = new StructurePerson();
            strX.FirstName = "Sophy";
            strX.LastName = "Yang";
            strY.FirstName = "Sophy";
            strY.LastName = "Yang";

            if (strX.Equals (strY))
            {
                Console.WriteLine("strX = strY"); //will return this, struct is value type
            }
            else
            {
                Console.WriteLine("strX != strY");
            }

            ClassPerson clsX = new ClassPerson();//class is reference type, object 1
            ClassPerson clsY = new ClassPerson();//class is reference type, object 2
            ClassPerson clsZ = clsX; //clsZ is assigned to object clsX
            clsX.FirstName = "Sophy";
            clsX.LastName = "Yang";
            clsY.FirstName = "Sophy";
            clsY.LastName = "Yang";
            if (clsX.Equals(clsY))
            {
                Console.WriteLine("clsX = clsY");
            }
            else
            {
                Console.WriteLine("clsX != clsY"); //will return this, class is reference type
            }

            clsX.FirstName = "Michael";
            if (clsX.Equals(clsZ))
            {
                Console.WriteLine("clsX = clsZ"); //will return this, since clsZ assigned object clsX
            }
            else
            {
                Console.WriteLine("clsX != clsZ");  
            }

             
            Cinterface.InterfaceTest(); //in interface1.cs public static method

            Square.AbstractDemoTest(); //in AbstractDemo.cs public static method

            DerivedClass.DerivedClassTest(); //in AbstractDemo.cs public static method

            Bike.BikeTest(); //in AbstractDemo.cs public static method

            B.InterfaceTest();

            EnumDemo.EnumDemoTest();

            refVSout.refVSoutTest();


            EmployeeTest.EmployeeDemo();
            StudentTest.StudentTestDemo();

            p.FistName = "MyFirstName";
            p.LastName = "MyLastName";
            Console.WriteLine("My full name is {0}", p.FullName );
            //p.FullName = "Sophy Yang"; read only cannot assigned value, only has get no set

            try
            {
                p.FistName = null ;
                p.LastName = "Yang";        
                Console.WriteLine("My full name is {0} ", p.FullName );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }


            ExtensionMethodDemoTest.ExtemsionMethod();

            StringVsStringBuilder s_sb = new StringVsStringBuilder();

            //DelegateDemo delegateDemo = new DelegateDemo();

            SealedClassTest sealedClassTest = new SealedClassTest();
            SealedClassDemo sealedClassDemo = new SealedClassDemo();
            
            sealedClassDemo.Add(6, 9);
             
            SealedClassTest.runSealedClass(); //static method cannot access by new keyword object


            SimpleDelegate simpleDelegate = new SimpleDelegate();
            simpleDelegate.NameDemo();

            Console.WriteLine("Name: " + p.Name);
            p.Address1 = "1100 Locust Street";
            p.Address2 = "Suit 100";
            p.City = "Des Moines";
            p.Zip = 50309;
            Console.WriteLine(p.SecondHomeAddress());
            Console.WriteLine(p.CompanyAddress());
            Console.WriteLine("");
            Console.WriteLine("");

            IEnumerableDemo ie = new IEnumerableDemo();

            YieldReturnDemo yr = new YieldReturnDemo();

            LateBindingEarlyBinding lbeb = new LateBindingEarlyBinding();

            //ManyToManyEfSample2 mtm2 = new ManyToManyEfSample2();
            //has error

            ConflictingMethodName cfMethod = new ConflictingMethodName();

            int xO = 5;
            int yO = xO / 10;
            Console.WriteLine("5/10=" + yO);
            yO = xO % 10;
            Console.WriteLine("5%10=" + yO);

            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");

            string result = list.Find(item => item == "a");
            if (list.Find(item => item == "a") is null)
            {
                Console.WriteLine("Not Find in List item: "  );
            }
            else
            {
                Console.WriteLine("Find List item: " + result);
            }


            string s = "abcabcbb";
            int largeCount = 0;
            
            string largeStr = string.Empty;
            
            int i1;
            for (  i1 = 0; i1 < s.Length; i1++)
            {
                List<string> l = new List<string>();
                int count = 0;
                string str1 = string.Empty;
               for (int j = i1; j < s.Length; j++)
                {
                    string s1 = s.Substring(j, 1);
                    if (l.Find(item => item == s1) is null)
                    {
                        l.Add(s.Substring(j, 1));
                        count += 1;
                        str1 += s1;
                         
                        Console.WriteLine("The large string lenght is " + largeCount + " (" + l.Count   + ") " + count);
                        
                    }
                    i1 = j;
                    if (largeCount < count)
                    {
                        largeCount = i1;
                        largeStr = str1;
                    }
                }
            }

            Console.WriteLine("The large string lenght is " + largeCount + " (" + largeStr + ") " );

            Console.WriteLine("0%2=" + 0 % 2);

            LeetCode le = new LeetCode();


           Console.ReadLine();
        }

 
    }
}
