using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompareTwoClass
    {
        public  CompareTwoClass() // default constructor
        {
            AClass cls1 = new AClass();
            BClass cls2 = new BClass();
            string str1 = "Test";
            string str2 = "Test";
            Console.WriteLine(Object.Equals(cls1, cls2)); //return False, since the two classes are not same
            Console.WriteLine(object.Equals(str1, str2)); //return True, since Test = Test
            Console.WriteLine(object.ReferenceEquals(cls1, cls2)); //return False
            cls1.AMethod();
            cls2.AMethod(); //BClass inheritance AClass and AMethod is public so can call it
            cls2.B2Method();
            cls2.B3Method(); //internal can be called in same .dll
            cls2.B4Method(); //protected internal can be called in current project and all members in derived class
             
            

        }
    }

    public class AClass : Object
    {
        public void AMethod()
        {
            Console.WriteLine("A Method");
        }
    }

    public class BClass: AClass //inheritance AClass
    {
        private void BMethod ()
        {
            Console.WriteLine("B Method");
        }
        protected void B1Method()
        {
            Console.WriteLine("B protected Method");
        }
        public void B2Method()
        {
            Console.WriteLine("B public Method");
        }
        internal void B3Method()
        {
            Console.WriteLine("B internal Method");
        }
        protected internal void B4Method()
        {
            Console.WriteLine("B protected internal Method");
        }
    }
}
