namespace PenaltyCalculationApp.Datas.Repository.Interface
{
    public interface IHolidayRepository
    {
        IEnumerable<Holiday> GetAllBySomeCountryId(int id);
    }
}
