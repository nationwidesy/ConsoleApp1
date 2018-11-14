using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DataTypeConversion
    {
        public   DataTypeConversion() // default constructor
        {
            int number;
            float weight;

            number = int.Parse("100");
            weight = float.Parse("300");
            Console.WriteLine("Your number is " + number);
            Console.WriteLine("Your weigh is " + weight);

            string num = "23";
            number = Convert.ToInt32(num);
            int age = 24;
            string vote = Convert.ToString(age);

            int num1, num2;
            float avg;
            num1 = 10;
            num2 = 21;
            avg = (float)(num1 + num2) / 2;


            byte b = 2;
            short s = 900;
            int i = 10;
            long l = 700000;
            float f = 3.6f;
            double d = 123.45;
            object obj = d; //implicit boxing

            b = (byte)s; //cashing small = (small)biger
            s = b;
            i = b;
            i = s;
            i = (int)l;
            l = b;
            l = s;
            l = i;
            l = (long)f;
            f = b;
            f = s;
            f = i;
            f = l;
            f = (float)d;
            d = b;
            d = s;
            d = i;
            d = l;
            d = f;
            //d = (double)obj;
            obj = d;
            obj = f;
            obj = l;
            obj = i;
            obj = s;
            obj = b;


            Console.WriteLine("byte = " + b);
            Console.WriteLine("short = " + s);
            Console.WriteLine("integet = " + i);
            Console.WriteLine("long = " + l);
            Console.WriteLine("Float = " + f);
            Console.WriteLine("double = " + d);
            Console.WriteLine("object = " + obj);
            //order
            //small ---- B,S,I,L,F,D, obj ---bigger
            //small = (small)bigger

        }
    }

    
}
