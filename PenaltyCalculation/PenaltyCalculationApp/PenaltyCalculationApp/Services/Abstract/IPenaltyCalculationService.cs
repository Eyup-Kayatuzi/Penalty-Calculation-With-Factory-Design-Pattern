using PenaltyCalculationApp.ViewModels;

namespace PenaltyCalculationApp.Services.Abstract
{
    public interface IPenaltyCalculationService
    {
        dynamic Calculate(int penaltyDays, string currency);
        int GetBusinessDays(PenaltyInputVM inputModel);
    }
}
