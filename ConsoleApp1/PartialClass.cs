using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PartialClass
    {
        static void PartialClassDemo()
        {
            MyClass obj = new MyClass();
            obj.myFunction_A();
            obj.myFunction_B();
        }
    }

    partial class MyClass
    {
        public void myFunction_A() { }
    }

    partial class MyClass
    {
        public void myFunction_B() { }
    }
}
