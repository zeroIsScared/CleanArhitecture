

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Domain.Models;

namespace Ecomerce.Infrastructure
{
    public class RealEstateRepository : IRealEstateRepository
    {
        private readonly List<RealEstate> _realEstates;
        public RealEstate Create(RealEstate realEstate)
        {
           _realEstates.Add(realEstate);
            return realEstate;
        }

        public int GetLastId()
        {
            if (_realEstates.Count == 0) return 1;
            var lastId = _realEstates.Max(x => x.Id);
            return lastId;
        }

        public List<RealEstate> GetRealEstateByIds(List<int> realEstateIds)
        {
            return _realEstates.Where(a => realEstateIds.Contains(a.Id)).ToList();
        }
    }
}
