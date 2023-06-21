namespace PenaltyCalculationApp.Datas
{
    public class Country
    {
        public Country()
        {
            Holidays = new List<Holiday>();//for initiation
        }
        public int Id { get; set; } // CountryId for Db
        public string Name { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public List<Holiday> Holidays { get; set; }// This line is added for one to many releations beteem holiday and Country. 
    }
}
