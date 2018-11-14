using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class SealedClassDemo
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

     class SealedClassTest
    {
        public static  void runSealedClass()
        {
            SealedClassDemo sealedCls = new SealedClassDemo();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString ());
        }
    }

    class SC  
    {
        public static void runSC()
        {
            Console.WriteLine("test..... ");
        }

    }

    class XXX
    {
        protected virtual void F()
        {
            Console.WriteLine("XXX.F");
        }
        protected virtual void F2()
        {
            Console.WriteLine("XXX.F2");
        }
    }
    class YYY:XXX
    {
        sealed protected override void F()
        {
            Console.WriteLine("YYY.F");
        }
         protected override void F2()
        {
            Console.WriteLine("YYY.F2");
        }

    }
    class ZZZ : YYY
    {
 /*  base class is sealed so derive can not has F()    
        protected override void F()
        {
            Console.WriteLine("ZZZ.F");
        }
*/        protected override void F2()
        {
            Console.WriteLine("ZZZ.F2");
        }

    }
}
