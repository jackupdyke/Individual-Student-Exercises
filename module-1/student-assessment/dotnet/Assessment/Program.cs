using Assessment.Models;
using System;
using System.Text;


namespace Assessment
{
     public class Program : WorkOrder
    {

        WorkOrder name = new WorkOrder();
        WorkOrder length = new WorkOrder();
        WorkOrder expectedTotal = new WorkOrder();

        // create an object and call methods on it
        // (manual testing) from this class.

        public Program(string name, int length, int width, int expectedTotal) : base(name, length, width)
        {

        }

            Program test = new Program("jack", 10, 20, 100);

        public override decimal ActualTotal(bool rush, bool icy)
        {
            return EstimatedTotal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"WORK ORDER - jack - $9.98");
            //hard coded values just to produce an output.
        }

    }
}
