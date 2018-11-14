using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Struct
 * Value type
 * stack not heap
 * System.Value
 * used for small amounts of data
 * cannot be inherited to other type
 * no need to create object by new keyword
 * cannot be abstract (method need has body)
 * cannot create default constructor (need has parameter)
 * field cannot be initialized unless they are declared as const or static
 */
namespace ConsoleApp1
{
    struct  StructurePerson //default constructor
    {
        public string FirstName; 
        public string LastName;
        //public string x = "not allowed initialized unless they are declared as const or static";
        public const int voteAge = 24;
        public int age;
    }

    class ClassPerson
    {
        public string FirstName;
        public string LastName;
    }
}
