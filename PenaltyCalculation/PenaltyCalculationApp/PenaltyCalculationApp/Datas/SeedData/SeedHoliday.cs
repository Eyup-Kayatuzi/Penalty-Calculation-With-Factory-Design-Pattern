using Microsoft.EntityFrameworkCore;

namespace PenaltyCalculationApp.Datas.SeedData
{
    public static class SeedHoliday
    {
        public static void AddHolidayData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Holiday>().HasData(new Holiday { Id = 1, Name = "Eid", Date = new DateTime(2023, 4, 3), CountryId = 2 });
            modelBuilder.Entity<Holiday>().HasData(new Holiday { Id = 2, Name = "Eid", Date = new DateTime(2023, 5, 4), CountryId = 2 });
            modelBuilder.Entity<Holiday>().HasData(new Holiday { Id = 4, Name = "29 Ekim Cumhuriyet Bayrami", Date = new DateTime(2023, 10, 29), CountryId = 1 });
        }
    }
}
