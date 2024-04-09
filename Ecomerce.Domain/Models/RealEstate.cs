using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.Domain.Models
{
    public class RealEstate
    {
        public int Id { get; set; }
        public required string City { get; set; }
        public required string Type { get; set; }
        public decimal Price {  get; set; }
    }
}
