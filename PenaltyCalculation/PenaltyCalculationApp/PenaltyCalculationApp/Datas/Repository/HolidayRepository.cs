using PenaltyCalculationApp.Datas.Repository.Interface;

namespace PenaltyCalculationApp.Datas.Repository
{
    public class HolidayRepository : IHolidayRepository
    {
        private readonly PenaltyCalculationContext _penaltyDbContext;
        public HolidayRepository(PenaltyCalculationContext penaltyDbContext)
        {
            _penaltyDbContext = penaltyDbContext;
        }

        public IEnumerable<Holiday> GetAllBySomeCountryId(int id)
        {
            return _penaltyDbContext.Holidays.Where(h => h.CountryId == id);
        }
    }
}
