

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Aplication.RealEstates.Responses;
using Ecomerce.Domain.Models;
using MediatR;

namespace Ecomerce.Aplication.RealEstates.Create;
    public record CreateRealEstate(string Type, string City, decimal Price) : IRequest<RealEstateDto>{
   
    public class CreateRealEstateHandler : IRequestHandler<CreateRealEstate, RealEstateDto>
    {
        private readonly IRealEstateRepository _realEstateRepository;
        public CreateRealEstateHandler(IRealEstateRepository realEstateRepository)
        {
            _realEstateRepository = realEstateRepository;
        }
        public Task<RealEstateDto> Handle(CreateRealEstate request, CancellationToken cancellationToken)
        {
            var realEstate = new RealEstate() { Type = request.Type, Id = GetNextId(), City = request.City, Price = request.Price };
            var createdRealEstate = _realEstateRepository.Create(realEstate);
            return Task.FromResult(RealEstateDto.FromRealEstate(createdRealEstate));
        }
        private int GetNextId()
        {
            return _realEstateRepository.GetLastId();
        }
    }
}
