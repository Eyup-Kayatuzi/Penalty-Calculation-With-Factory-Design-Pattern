using PenaltyCalculationApp.Datas;
using Microsoft.EntityFrameworkCore;
using PenaltyCalculationApp.Services.Abstract;
using PenaltyCalculationApp.Services.Concrete;
using PenaltyCalculationApp.Services;
using ServiceLayer.FactoryPattern;
using ServiceLayer;
using PenaltyCalculationApp.Datas.Repository.Interface;
using PenaltyCalculationApp.Datas.Repository;

namespace PenaltyCalculationApp.Extensions
{
    public static class DependecyInjection
    {
        public static void AddGeneralServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PenaltyCalculationContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); // Adding to services for accesing it as dependency injection at constructure
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IHolidayRepository, HolidayRepository>();
            services.Add(typeof(IPenaltyCalculationService), typeof(TurkeyPenaltyCalculationService), CountryEnum.TR.GetName(), ServiceLifetime.Transient);
            services.Add(typeof(IPenaltyCalculationService), typeof(UnitedArabEmiratesPenaltyCalculationService), CountryEnum.AE.GetName(), ServiceLifetime.Transient);// farklı enumlarında eklemesi icin

            services.AddSingleton<IPenaltyCalculationFPResolver, PenaltyCalculationFPResolver>();

            services.AddSingleton<IPenaltyCalculationProcessor, PenaltyCalculationProcessor>();

        }
    
    }
}
