using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Person
    {

        //auto getter and setter --> propfull --> press Tab twice
        private int myAge;

        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }


        private string mName = string.Empty ;

        public string pName
        {
            get { return mName; }
            set { mName = value; }
        }

        private string mAddress;

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        private string mCity;

        public string City
        {
            get { return mCity; }
            set { mCity = value; }
        }
        private string mState;

        public string State
        {
            get { return mState; }
            set { mState = value; }
        }
        private int mZip;

        public int Zip
        {
            get { return mZip; }
            set { mZip = value; }
        }

 
        public string Company
        {
            //read only property
            get { return "Nationwide Insurance"; }
        }

        private string mNotes = string.Empty;
        public string showNotes
        {
            get { return mNotes; }
        }
  
        public string Notes
        {
            set { mNotes = value; }
        }

        private string myFirstName = string.Empty;
        private string myLastName = string.Empty;
         
        //Write only property only has set
        public string FistName
        {
            set {  myFirstName = value; }
        }
        public string LastName
        {
            set {  myLastName = value; }
        }
        //read only property only has get
        public string FullName
        {
            get {
                 if ((myFirstName == null) || (myLastName == null ) )
                {
                    throw new Exception("Error !!! Name can not be blank");
                } 
                return myFirstName + " " + myLastName; }
        }
    }

    
}
