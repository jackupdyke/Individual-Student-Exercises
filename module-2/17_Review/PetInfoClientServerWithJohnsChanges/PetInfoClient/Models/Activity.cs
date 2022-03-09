using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoClient.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Pet { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Date} - {Pet}";
        }
    }
}
