using PenaltyCalculationApp.Services.Abstract;
using ServiceLayer.FactoryPattern;

namespace PenaltyCalculationApp.Services.Concrete
{
    public class PenaltyCalculationFPResolver : FactoryPatternResolver<IPenaltyCalculationService, CountryEnum>, IPenaltyCalculationFPResolver
    {
        public PenaltyCalculationFPResolver(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {

        }
    }
}
