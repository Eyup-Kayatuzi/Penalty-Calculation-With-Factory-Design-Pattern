namespace PenaltyCalculationApp.Datas.Repository.Interface
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll { get; }

        Task<Country> GetCountryByIdAsync(int countryId);
        Country GetCountryById(int countryId);
    }
}
