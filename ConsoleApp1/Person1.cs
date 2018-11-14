using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person1
    {
    }

    partial class Person
    {
 
        public string  CompanyAddress()
        {
            return Company + ": " +_Address1 + ", " + Address2 + ", " + City + ", " + State + " " + Zip;
        }
    }
}
