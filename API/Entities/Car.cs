using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int YearModel { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Licensed { get; set; }
        public string Name { get; set; }
    }
}