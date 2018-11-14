using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LateBindingEarlyBinding
    {
        public LateBindingEarlyBinding ()
        {
            class1 obj1 = new class1();
            obj1.methodA();
            obj1.methodC();
            obj1.methodD();
            obj1.Show();
            class1 obj2 = new class2();
            obj2.methodA();
            obj2.methodC();
            obj2.methodD();
            obj2.Show();
            class1 obj3 = new class3();
            obj3.methodA();
            obj3.methodC();
            obj3.methodD();
            obj3.Show();
            class1 obj4 = new class4();
            obj4.methodA();
            obj4.methodC();
            obj4.methodD();
            obj4.Show();

            MethodB(4);
            MethodB(54, "sophy");
            MethodB("tammy");

          
         }

        //early binding
        //compile time polymorphism
        //overloading
        //multiply methods with same name
        public void MethodB (int i)
        {
            Console.WriteLine("in MethodB with int para " + i);
        }
        public void MethodB( string str)
        {
            Console.WriteLine("in MethodB with  string para " + str);
        }
        public void MethodB(int i, string str)
        {
            Console.WriteLine("in MethodB with int para " + i+ " and string para " + str);
        }
    }

    class class1 //base preent
    {
        public virtual void methodA()
        {
            Console.WriteLine("in Class1 methodA");
        }
        public virtual void methodC()
        {
            Console.WriteLine("in Class1 methodC");
        }
        public virtual void methodD()
        {
            Console.WriteLine("in Class1 methodD");

        }
        public virtual void Show()
        {
            Console.WriteLine("in Class1 Show()");
        }
    }

    class class2 : class1 //deriver child
        //overrider parent method, 
        //late binding
        //Run time ploymorphism
    {
        public override void methodA()
        {
            Console.WriteLine("in Class2 methodA");
        }   
        
        public override void methodC()
        {
            Console.WriteLine("in Class2 methodC");
        }
 
        public new void Show()
        {
            Console.WriteLine("in class2 Show()");
        }

    }

    class class3: class1
    {
        public  override void methodA()
        {
            Console.WriteLine("in Class3 methodA");
        }
        public sealed override void methodC()
        {
            Console.WriteLine("in Class3 sealed methodC");
        }
        public override void methodD() //Using the "new" keyword, we can hide the base class member.
        {
            Console.WriteLine("in Class3 methodD, Using the new keyword, we can hide the base class member. method hiding");

        }
    }
    class class4 : class1
    {
        public  override void methodA()
        {
            Console.WriteLine("in Class4 methodA");
        }
        public new void methodD() //Using the "new" keyword, we can hide the base class member.
        {
            Console.WriteLine("in Class4 methodD, Using the new keyword, we can hide the base class1 member. method hiding");

        }
        /*
           * cannot override sealed method
          public sealed override void methodC()
          {
              Console.WriteLine("in Class4 methodC");
          }
          */
    }
}
