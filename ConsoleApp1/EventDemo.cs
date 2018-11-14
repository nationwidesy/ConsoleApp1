using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EventHandler and EventHandler<TEventArgs> are delegate
//EventHandler has no data
//EventHandler<TeventArgs> has data
namespace ConsoleApp1
{
    class EventDemo
    {
        //1. delegate
        //declare a delegate, no return type for delegate (void)
        public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs1 e);

        private int threshold;
        private int total;

        //2. event
        public event ThresholdReachedEventHandler ThresholdReached;

        public EventDemo()
        {
            Counter(new Random().Next(10));
            ThresholdReached += c_ThresholdReached; //add method to event

            Console.WriteLine("press 'a' key to increase total.");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                Add(1);
            }
        } 

        public void Counter(int passThreshold)
        {
            threshold = passThreshold;
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs1  e)
        {
            ThresholdReachedEventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        
        //3. eventHander
        static void c_ThresholdReached (object sender, ThresholdReachedEventArgs1 e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Environment.Exit(0);
        }

        //4. method
        public void Add(int x)
        {
            total += x;
            if (total >= threshold )
            {
                ThresholdReachedEventArgs1 args = new ThresholdReachedEventArgs1();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            } 
        }
    }

    //Even with data
    //derives from EventArgs
    public class ThresholdReachedEventArgs1 : EventArgs
    {
        public int Threshold { get; set; } //property (data)
        public DateTime TimeReached { get; set; } //property
    }

  
}
