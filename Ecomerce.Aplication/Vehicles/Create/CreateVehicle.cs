

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Aplication.Vehicles.Responses;
using Ecomerce.Domain.Models;
using MediatR;

namespace Ecomerce.Aplication.Vehicles.Create;
public record CreateVehicle(string Model, string Brand, decimal Price) : IRequest<VehicleDto>;

public class CreateVehicleHandler : IRequestHandler<CreateVehicle, VehicleDto>
{
    private readonly IVehicleRepository _vehicleRepository;
    public CreateVehicleHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }
    public Task<VehicleDto> Handle(CreateVehicle request, CancellationToken cancellationToken)
    {
        var vehicle = new Vehicle() {Id = GetNextId(), Model = request.Model, Brand = request.Brand,  Price = request.Price };
        var createdVehicle = _vehicleRepository.Create(vehicle);
        return Task.FromResult(VehicleDto.FromVehicle(createdVehicle));
    }

    private int GetNextId()
    {
        throw new NotImplementedException();
    }
}

