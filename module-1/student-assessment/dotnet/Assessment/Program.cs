using Assessment.Models;
using System;
using System.Text;


namespace Assessment
{
     public class Program : WorkOrder
    {
        public static void Main(string[] args)
        {

            WorkOrder test = new WorkOrder("jack", 20, 30);
            
            test.ActualTotal(false, true);
            
                
            
               
            Console.WriteLine($"WORK ORDER - {test.Name} - ${test.EstimatedTotal}");

            
        }
    }
        
   
    
}
