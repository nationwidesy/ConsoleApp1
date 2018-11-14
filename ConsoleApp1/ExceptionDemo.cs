using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExceptionDemo
    {
        public void ExceptionMethod()
        {
            throw new Exception("Original Exception occurred in Sophy's ExceptionMethod");
        }
        public void AnotherMethod()
        {
            ExceptionDemo e = new ExceptionDemo();
            try
            {
                e.ExceptionMethod();
            }
            catch (Exception exe)
            {
                //throw; //this line will do the re-trhow
                throw new ApplicationException("sophy's operation failed", exe);
            }
        }
        public void SophyExceptionArgumentDemo(string[] args)
        {
            try
            {
                string arg = args.Length >= 2 ? args[0] : throw new ArgumentException("You must supply a argument");

                if (Int64.TryParse(arg, out var number))
                    Console.WriteLine($"You entered {number:F0}");
                else
                    Console.WriteLine($"{arg} is not a number.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The error occurred. (" + e.Message + ")");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
