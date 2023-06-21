using PenaltyCalculationApp.ViewModels;

namespace PenaltyCalculationApp.Services.Abstract
{
    public interface IPenaltyCalculationProcessor
    {
        PenaltyOutputVM Process(PenaltyInputVM inputViewModel);
    }
}
