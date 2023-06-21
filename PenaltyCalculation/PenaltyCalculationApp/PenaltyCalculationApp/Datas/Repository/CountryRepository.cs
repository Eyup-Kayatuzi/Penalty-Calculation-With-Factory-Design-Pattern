using Microsoft.EntityFrameworkCore;
using PenaltyCalculationApp.Datas.Repository.Interface;
using System;

namespace PenaltyCalculationApp.Datas.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly PenaltyCalculationContext _penaltyDbContext;
        public CountryRepository(PenaltyCalculationContext penaltyDbContext)
        {
            _penaltyDbContext = penaltyDbContext;
        }
        public IEnumerable<Country> GetAll => _penaltyDbContext.Countries;

        public Country GetCountryById(int countryId)
        {
            return _penaltyDbContext.Countries.FirstOrDefault(x => x.Id == countryId); // this line returns firs occurence from db otherwise retuns null.
        }

        public async Task<Country> GetCountryByIdAsync(int countryId)
        {
            return await _penaltyDbContext.Countries.FirstOrDefaultAsync(x => x.Id == countryId);
        }
    }
}
