using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person2
    {
    }

    partial class Person
    {
        private string _Address1;
         

        public string Address1 { get { return _Address1; }  set { _Address1 = value; } }
        public string Address2 { get; set; }

        public string SecondHomeAddress()
        {
            return _Address1 + ", " + Address2 + ", " + City + ", " + State + " " + Zip;
        }

    }
}
