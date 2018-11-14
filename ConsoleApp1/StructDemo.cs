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
 * Struct is sealed, cannot deriver a class from a struct
 */
namespace ConsoleApp1
{
    public struct StructDemo
    {
        public int x, y; 
        
        public StructDemo(int p1, int p2) //parameterized constructor
        {
            //can't not be abstract, method need has body
            x = p1;
            y = p2;
        }
  
    }
}
