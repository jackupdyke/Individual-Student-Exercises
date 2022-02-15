using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class WorkOrder 
    {
        public WorkOrder()
        {

        }
        public WorkOrder(string name, int length, int width)
        {
            Name = name;
            Length = length;
            Width = width;
        }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public decimal EstimatedTotal { get; set; }
        
        
        public virtual decimal ActualTotal(bool rush, bool icy)
        {
            decimal rushFee = 16.98M;
            decimal icyFee = 24.75M;

            if(rush == true && icy == true)
            {
                return EstimatedTotal = (Length * Width / 100.00M * 4.99M) + (2 * rushFee) + (icyFee);
            }
            else if(rush == true && icy == false)
            {
               return  EstimatedTotal = (Length * Width / 100.00M * 4.99M) + rushFee;
            }
            else if(rush == false && icy == true)
            {
               return EstimatedTotal = (Length * Width / 100.00M * 4.99M) + icyFee;
            }
            else
            {
                return EstimatedTotal = (Length * Width / 100.00M * 4.99M);
            }
        }

        //public virtual string ToString()
        //{
        //    return "WORK ORDER - {name} - {estimated total}";
        //}
            

        
    }
}
