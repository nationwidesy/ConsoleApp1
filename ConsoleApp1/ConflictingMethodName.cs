using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //inherit multiple interface
    //have conflicting method name
    //don't use keywork public
    class ConflictingMethodName
    {
        public ConflictingMethodName()
        {
            IShow I = new BB();
            I.Show();
            IShow_Case Ii = new BB();
            Ii.Show();
        }
    }

    interface IShow
    {
        void Show();
    }

    interface IShow_Case
    {
        void Show();
    }

    class BB : IShow, IShow_Case
    {
          void IShow.Show()
        {
            Console.WriteLine("IShow Interface function");
        }
          void IShow_Case.Show()
        {
            Console.WriteLine("IShow_Case Interface function");
        }
    }
}
