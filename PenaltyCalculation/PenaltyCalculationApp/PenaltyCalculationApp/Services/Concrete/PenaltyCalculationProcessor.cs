using PenaltyCalculationApp.Services.Abstract;
using PenaltyCalculationApp.ViewModels;

namespace PenaltyCalculationApp.Services.Concrete
{
    public class PenaltyCalculationProcessor : IPenaltyCalculationProcessor
    {
        private readonly IPenaltyCalculationFPResolver _factoryPatternResolver;
        public PenaltyCalculationProcessor(IPenaltyCalculationFPResolver factoryPatternResolver)
        {
            _factoryPatternResolver = factoryPatternResolver;
        }
        public PenaltyOutputVM Process(PenaltyInputVM inputViewModel)
        {
            if (inputViewModel == null)
                throw new Exception($"{typeof(PenaltyInputVM).FullName} can not be null!");
            try
            {
                var _countryEnum = (CountryEnum)System.Enum.Parse(typeof(CountryEnum), inputViewModel.Country.Currency);

                var _penaltyCalculationService = _factoryPatternResolver.Resolve(_countryEnum);

                var businessDays = _penaltyCalculationService.GetBusinessDays(inputViewModel);

                var result = _penaltyCalculationService.Calculate(businessDays, inputViewModel.Country.Currency);

                return new PenaltyOutputVM { BusinessDays = businessDays, TotalPenaltyPrice = result.TotalPrice, ForCurrency = result.Currency };
            }
            catch
            {

            }
            return new PenaltyOutputVM();
        }
    }
}
