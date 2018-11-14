using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BoxingUnboxing
    {
        public BoxingUnboxing () // default constructor
        {
            byte b = 2;
            short s = 900;
            int i = 10;
            long l = 700000;
            float f = 3.6f;
            double d = 123.45;        
            object obj = i; //implicit boxing
           

            int i_o = (int)obj; //explicit unboxing, casting
            float f_d = (float)3.5;

            object o1 = (object)i; //explicit boxing, boxing don't nee do casting
            object o2 = i; //implicit boxing
 
            Int32 x = 5;
            obj = x; //implicit boxing
            x = (Int32)obj; //explicit unboxing

            obj = d; //implicit boxing
            d = (double)obj; //explicit unboxing

 



        }
    }
}
