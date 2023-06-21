using PenaltyCalculationApp.Services.Abstract;
using PenaltyCalculationApp.ViewModels;
using System.Globalization;

namespace PenaltyCalculationApp.Services.Concrete
{
    public class UnitedArabEmiratesPenaltyCalculationService : IPenaltyCalculationService
    {
        private readonly decimal PenaltyForEachDayPrice = 7;
        private readonly int PenaltyDaysLimit = 10;

        public dynamic Calculate(int days, string currency)
        {
            var TotalPrice = days > PenaltyDaysLimit ? (days - PenaltyDaysLimit) * PenaltyForEachDayPrice : 0;

            var CurrencySymbol = new RegionInfo(currency).CurrencySymbol.ToString();

            return new { TotalPrice = TotalPrice, Currency = CurrencySymbol };
        }

        public int GetBusinessDays(PenaltyInputVM inputModel)
        {
            int TotalBusinessDays = 0;

            var holidays = inputModel.Country.Holidays.Select(s => s.Date);

            var dayDifference = (int)inputModel.ToDate.Subtract(inputModel.FromDate).TotalDays;

            for (var date = inputModel.FromDate; date <= inputModel.ToDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Friday
                    && date.DayOfWeek != DayOfWeek.Saturday
                    && !holidays.Contains(date))
                    TotalBusinessDays++;
            }

            return TotalBusinessDays;
        }
    }
}
