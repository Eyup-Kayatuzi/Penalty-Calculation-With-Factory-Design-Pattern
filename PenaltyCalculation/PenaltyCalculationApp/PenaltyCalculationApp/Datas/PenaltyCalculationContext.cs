using Microsoft.EntityFrameworkCore;
using PenaltyCalculationApp.Datas.SeedData;

namespace PenaltyCalculationApp.Datas
{
    public class PenaltyCalculationContext : DbContext
    {
        public PenaltyCalculationContext(DbContextOptions<PenaltyCalculationContext> options): base(options)
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedCountry.AddCountryData(modelBuilder);//seed country
            SeedHoliday.AddHolidayData(modelBuilder);// seed holiday
            base.OnModelCreating(modelBuilder);
        }
    }
}
