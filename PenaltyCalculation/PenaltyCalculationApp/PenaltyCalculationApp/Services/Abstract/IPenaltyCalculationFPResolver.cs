using ServiceLayer.FactoryPattern.Interface;

namespace PenaltyCalculationApp.Services.Abstract
{
    public interface IPenaltyCalculationFPResolver : IFactoryPatternResolver<IPenaltyCalculationService, CountryEnum>
    {
    }
}
