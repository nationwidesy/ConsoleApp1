using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Voter
    {
        private int mAge = 0;

        public int Age
        {
            get { return mAge; }
            set //validate property value
            {
                if (value >= 18)
                {
                    mAge = value;
                }
                else
                {
                    Console.WriteLine("You are not eligible for voting");
                }
                }
            }
        }


    }

