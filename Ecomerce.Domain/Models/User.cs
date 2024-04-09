using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomerce.Domain.Models
{
    public class User
    {
        private readonly List<Vehicle> _vehicles = new();
        private readonly List<RealEstate> _realEstates = new();
        public User()
        {
            Vehicles = _vehicles;
            RealEstates = _realEstates;
        }
        public int Id { get; set; }
        public required string Name { get; set;}
        ICollection<Vehicle> Vehicles { get; set; }
        ICollection<RealEstate> RealEstates { get; set; }
    }
}
