using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public required string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
