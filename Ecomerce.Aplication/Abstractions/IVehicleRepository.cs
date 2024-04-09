using Ecomerce.Domain.Models;


namespace Ecomerce.Aplication.Abstractions
{
    public interface IVehicleRepository
    {
        Vehicle Create(Vehicle vehicle);
        List<Vehicle> GetRealEstateByIds(List<int> vehicleIds);
        int GetLastId();
    }
}
