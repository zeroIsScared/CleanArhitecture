

using Ecomerce.Domain.Models;

namespace Ecomerce.Aplication.Vehicles.Responses
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public required string Brand { get; set; }
        public decimal Price { get; set; }
        public static VehicleDto FromVehicle(Vehicle vehicle)
        {
            return new VehicleDto
            {
                Id = vehicle.Id,
                Model = vehicle.Model,
                Brand = vehicle.Brand,
                Price = vehicle.Price,
            };
        }
    }
}
