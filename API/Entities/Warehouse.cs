using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public Car Car { get; set; }
    }
}