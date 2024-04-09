using Ecomerce.Domain.Models;

namespace Ecomerce.Aplication.Abstractions
{
    public interface IRealEstateRepository
    {
        RealEstate Create(RealEstate realEstate);
        List<RealEstate> GetRealEstateByIds(List<int> realEstateIds);
        int GetLastId();
    }
}
