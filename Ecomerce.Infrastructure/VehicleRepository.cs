

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Domain.Models;

namespace Ecomerce.Infrastructure
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles;
        public Vehicle Create(Vehicle vehicle)
        {
           _vehicles.Add(vehicle);
            return vehicle;
        }

        public int GetLastId()
        {
            if (_vehicles.Count == 0) return 1;
            var lastId = _vehicles.Max(a => a.Id);
            return lastId + 1;
        }

        public List<Vehicle> GetRealEstateByIds(List<int> vehicleIds)
        {
            return _vehicles.Where(a => vehicleIds.Contains(a.Id)).ToList();
        }
    }
}
