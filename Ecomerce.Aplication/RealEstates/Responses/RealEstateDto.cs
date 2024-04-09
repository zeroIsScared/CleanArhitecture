using Ecomerce.Domain.Models;


namespace Ecomerce.Aplication.RealEstates.Responses
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public required string City { get; set; }
        public required string Type { get; set; }
        public decimal Price { get; set; }
        public static RealEstateDto FromRealEstate(RealEstate realEstate)
        {
            return new RealEstateDto
            {
                Id = realEstate.Id,
                City = realEstate.City,
                Type = realEstate.Type,
                Price = realEstate.Price,
            };
        }
    }
}
