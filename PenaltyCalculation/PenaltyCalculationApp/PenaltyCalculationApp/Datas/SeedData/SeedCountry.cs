using Microsoft.EntityFrameworkCore;

namespace PenaltyCalculationApp.Datas.SeedData
{
    public static class SeedCountry
    {
        public static void AddCountryData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Turkey", Currency = "TR" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "United Arab Emirates", Currency = "AE" });
        }
    }
}
