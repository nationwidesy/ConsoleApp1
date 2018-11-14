using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//auto mapped property

namespace ConsoleApp1
{
    public class Employee
    {
        //Of Auto Implementmented Property, get; set; 
        //auto mapped property, don't need define
        //a local private value  
        public int EmployeeId { get; set; }
        public string Name { get; set;  }
        private string mAddress { get; set; }
        private string mCity { get; set; }

        private int mBonus = 5000;
        public int Bonus
        {
            get { return this.mBonus; }
            set { mBonus  = value; }
        }

        //method has ()
        public void SetID(int id)
        {
            if (id < 1)
            {
                throw new Exception("Employee ID cannot be less than 1");
            } 
            this.EmployeeId = id;  
        }
        public int GetId()
        {
            return this.EmployeeId;
        }
     }

    public class EmployeeTest
    {
        public static void EmployeeDemo()
        {
            //2 ways to set Employee value
            Employee e = new Employee()
            {
                EmployeeId = 1001, //use , not ;
                Name = "Sophy"
            }; // need ; here
            //property don't need (), method need ()
            Console.WriteLine("Employee Id is : {0} and Employee Name is  {1}", e.EmployeeId,e.Name );

            Employee e1 = new Employee();
            e1.Name = "Tammy";
            e1.EmployeeId = 1002;
            Console.WriteLine("Employee Id is : {0} and Employee Name is  {1}", e1.EmployeeId, e1.Name);
            e1.Name = "Michael";
            e1.EmployeeId = 1003;
            Console.WriteLine("Employee Id is : {0} and Employee Name is  {1}", e1.EmployeeId, e1.Name);
            try
            {
            e1.Name = "James"; //property
            e1.SetID(-100); //Method
            Console.WriteLine("Employee Id is : {0} and Employee Name is  {1}", e1.GetId() , e1.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message );
            }
            e1.Name  = "Chu"; //property
            e1.SetID(1005); //Method
            Console.WriteLine("Employee Id is : {0} and Employee Name is  {1}", e1.GetId(), e1.Name);
        }
    }
}
