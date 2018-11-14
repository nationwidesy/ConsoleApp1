using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringVsStringBuilder
    {
        public StringVsStringBuilder()
        {
            //defalut constractor
            Console.WriteLine("Just create a object by new keyword, in default constractor");
            StringVsStringBuilderDemo();
            StringBuilderDemo();
        }

        public static void StringVsStringBuilderDemo()
        {
            string str = string.Empty;
            string str1;
            string str2 = string.Empty;
            string str3 = string.Empty;
            str += "My name is ";
            str += "Sophy ";
            str += "Yang.";
            str1 = str;
            if (str == str1) { str2 = ""; } else { str2 = "not"; }
            Console.WriteLine("\"{0}\" is {1} same as \"{2}\"", str, str2, str1);

            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = sb;
            string strSB = sb.ToString(); //convert StringBuider to string

            sb.Append("My name is ");
            sb.Append("Sophy ");
            sb.Append("Yang.");
            sb1.Append(" Happy friend day!!!");
            if (sb.Equals (sb1)) { str2 = ""; } else { str2 = "not"; }
            if (sb == sb1) { str3 = ""; } else { str3 = "not"; }
            Console.WriteLine("\"{0}\" is {1} same as \"{2}\"", sb.ToString (), str2, sb1.ToString ());
            Console.WriteLine("object \"{0}\" is {1} same as object \"{2}\"", sb , str3, sb1 );
        }

        public static void StringBuilderDemo()
        {
            int myInt = 25;
            StringBuilder sb = new StringBuilder("Hello World!");
            sb.Append(" What a beautiful day,");
            sb.AppendLine();
            sb.Append("Your total is ");
            sb.AppendFormat("{0:C}", myInt);
            sb.Insert(6, "Beautiful "); //6 is index, so insert start at position 7
            sb.Remove(6, 10); //remove start at index 6, remove total 10 char
            sb.Replace('!', '?').Replace (',', '!');
            Console.WriteLine(sb);

            string[] spellings = { "receive", "receeve", "receive" };
            sb.Clear();
            bool flag = true;
            sb.AppendFormat("Which of following spelling is {0}", flag );
            sb.AppendLine();
            for(int i=0; i<=spellings.GetUpperBound (0); i++)
            {
                sb.AppendFormat("    {0}. {1}", i, spellings[i]);
                sb.AppendLine();
            }
            Console.WriteLine(sb);


        }
    }
}
