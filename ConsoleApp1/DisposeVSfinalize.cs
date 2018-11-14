using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DisposeVSfinalize : IDisposable //implement interface IDisposable
    {
        private bool disposed = false;

        public void Dispose() //implement IDisposable interface
        {
            Dispose(true); //IDisposable no parameter, in this class use virtual method to redefine it to take one parameter
            GC.SuppressFinalize(this); //Garbage collector
        }

        //virtual method
        //redefine in derived class
        //base class has Dispose, virtual in derived class to redefine it
        protected virtual void Dispose (bool disposing)
        {
            if (!disposed)
            {
                if (disposing) {
                    //clean up managed object 
                }
            }
                //clean up unmanaged object
            disposed = true;
        }

        public DisposeVSfinalize()
        {
            //default Constructor
        }

        ~DisposeVSfinalize() //at runtime automatically converted to Finalize method
        {
            //Destructor also called Finalize
            this.Dispose();
        }
    }
}
