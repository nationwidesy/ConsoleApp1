using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private int mMarks;
        //get input Marks value from set {}
        //then return Mark value from get{}
        public int Marks //Marks is property so no ()
        {
            get {
                if (mMarks >=80) { mMarks += 5; }
                else if(mMarks <=79 && mMarks >=70) { mMarks += 2; }
                return mMarks; }
            set { mMarks = value; }
        }

    }

    public class StudentTest
    {
        public static void StudentTestDemo()
        {
            Student s = new Student();
            s.Marks = 85; //Marks is property, the 85 will use to set{} value, then get{} will use the value
            Console.WriteLine("The scode is 85 and Mark is {0}", s.Marks );
        }
    }

}
